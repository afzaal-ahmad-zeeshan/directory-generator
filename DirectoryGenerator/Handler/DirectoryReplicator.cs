using DirectoryGenerator.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DirectoryGenerator.Handler
{
    public class DirectoryReplicator
    {
        private Request _request { get; set; }

        public DirectoryReplicator(Request request) => _request = request;

        public async Task<string> GenerateAsync()
        {
            var result = "";
            int _folders = 0;

            return null;
        }
    }
}
