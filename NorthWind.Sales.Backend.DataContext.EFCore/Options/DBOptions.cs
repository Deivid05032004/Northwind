using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.Sales.Backend.DataContext.EFCore.Options
{
    public class DBOptions
    {
        //DBOption se puede almacenar en el archivo de configuracion Web: AppSettings.json key
        public const string SectionaKey = nameof(DBOptions);
        public string ConnectionString { get; set; } = string.Empty;
    }
}
