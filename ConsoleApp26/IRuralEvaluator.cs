using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp26
{
    interface IRuralEvaluator
    {
        public double GetTotalKg(List<CropField> cropFields);
        public List<string> GetAllRegions(List<CropField> cropFields);
        {

        }
    }
}
