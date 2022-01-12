using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp26
{
    class MinistryBid
    {
        List<CropField> fields;
        IRuralEvaluator evaluator;


        public MinistryBid(IRuralEvaluator evaluator)
        {
            fields = new List<CropField>();
            this.evaluator = evaluator;
        }

        public void SetEvaluator(IRuralEvaluator evaluator)
        {
            this.evaluator = evaluator;
        }

        public List<string> GetRegions()
        {
            return evaluator.GetAllRegions(fields);
        }

    }
}
