using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp26
{
    class StdEvaluator: IRuralEvaluator
    {
        private List<string> supportedRegions;

        public StdEvaluator(List<string> supportedRegions)
        {
            this.supportedRegions = new List<string>();
            this.supportedRegions.AddRange(supportedRegions);
        }

        public List<string> GetAllRegions(List<CropField> cropFields)
        {
            return null;
        }

        public double GetTotalKg(List<CropField> cropFields)
        {
            return 3;
        }
    }
}
