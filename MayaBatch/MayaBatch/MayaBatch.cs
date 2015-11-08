using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace MayaBatch
{
    public class RenderBatch
    {
        public string binDirectory { get; set; }
        public int startFrame { get; set; }
        public int endFrame { get; set; }
        public string cameraName { get; set; }
        public string fileDirectory { get; set; }
        public string fileName { get; set; }
        public string outputFileDirectory { get; set; } 
        public string outputFilePrefix { get; set; }
        public string outputFormat { get; set; }

        public bool Render()
        {
            string arguments = String.Format(" -s {0} -e {1} -cam {2} -r mr -rd \"{3}\" -im \"{4}\" \"{5}\\{6}\"", this.startFrame, this.endFrame, this.cameraName, this.outputFileDirectory, this.outputFilePrefix, this.fileDirectory, this.fileName);
            string executable = String.Format("{0}\\render", this.binDirectory);

            Console.Write(executable);
            Console.Write(arguments);
            Process.Start(executable,arguments);
            return false;
        }

    }
}
