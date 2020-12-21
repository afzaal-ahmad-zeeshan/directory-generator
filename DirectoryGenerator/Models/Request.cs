using System;
using System.Collections.Generic;
using System.Text;

namespace DirectoryGenerator.Models
{
    public class Request
    {
        public string _inputDirectory { get; set; }
        public string _outputDirectory { get; set; }
        public string _structure { get; set; }

        public Request(string inputDirectory, string outputDirectory, string structure) => (_inputDirectory, _outputDirectory, _structure) = (inputDirectory, outputDirectory, structure);
    }
}
