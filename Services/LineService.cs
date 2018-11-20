
using CuantoGastoApp.Context;
using CuantoGastoApp.Model;

namespace CuantoGastoApp.Services
{
    public class LineService: ILineService
    {
        public void SaveLine(Line line)
        {
            try
            {
                using (var context = new GlobalContext()) 
                {
                    context.Line.Add(line); 
                     context.SaveChanges();
                }      
            }
            catch (System.Exception e)
            {
              throw e;
            }
          
        }

    }
}