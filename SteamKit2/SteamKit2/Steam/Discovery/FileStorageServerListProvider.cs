﻿using ProtoBuf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace SteamKit2.Discovery
{
    /// <summary>
    /// A server list provider that uses a file to persist the server list using protobuf
    /// </summary>
    public class FileStorageServerListProvider : IServerListProvider
    {
        string filename;

        /// <summary>
        /// Initialize a new instance of FileStorageServerListProvider
        /// </summary>
        public FileStorageServerListProvider(string filename)
        {
            this.filename = filename;
        }

        /// <summary>
        /// Read the stored list of servers from the file
        /// </summary>
        /// <returns>List of servers if persisted, otherwise an empty list</returns>
        public Task<IEnumerable<IPEndPoint>> FetchServerListAsync()
        {
            return Task.Run(() =>
            {
                try
                {
                    using (FileStream fileStream = File.OpenRead(filename))
                    {
                        return ProtoBuf.Serializer.DeserializeItems<BasicServerListProto>(fileStream, PrefixStyle.Base128, 1)
                            .Select(item => new IPEndPoint(IPAddress.Parse(item.ipAddress), item.port))
                            .ToList();
                    }
                }
                catch (IOException ex)
                {
                    DebugLog.WriteLine("FileStorageServerListProvider", "Failed to read file {0}: {1}", filename, ex.Message);
                    return Enumerable.Empty<IPEndPoint>();
                }
            });
        }

        /// <summary>
        /// Writes the supplied list of servers to persistent storage
        /// </summary>
        /// <param name="endpoints">List of server endpoints</param>
        /// <returns>Awaitable task for write completion</returns>
        public Task UpdateServerListAsync(IEnumerable<IPEndPoint> endpoints)
        {
            return Task.Run(() =>
            {
                try
                {
                    using (FileStream fileStream = File.OpenWrite(filename))
                    {
                        ProtoBuf.Serializer.Serialize(fileStream, 
                            endpoints.Select(ep => new BasicServerListProto {ipAddress = ep.Address.ToString(), port = ep.Port}));
                        fileStream.SetLength(fileStream.Position);
                    }
                }
                catch (IOException ex)
                {
                    DebugLog.WriteLine("FileStorageServerListProvider", "Failed to write file {0}: {1}", filename, ex.Message);
                }
            });
        }
    }
}
