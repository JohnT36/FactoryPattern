using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    class DataAccessFactory
    {
         public static IDataAccess DataAccessType(string databaseType)
        {
            switch(databaseType.ToLower())
            {
                case  "sql":
                        return new SQLDataAccess();
                    case  "mango":
                        return new MangoDataAccess();
                    case  "list":
                        return new ListDataAccess();
                default:
                    return new ListDataAccess();
                        
            }
        }


    }
}
