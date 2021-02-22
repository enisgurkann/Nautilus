using System;
using System.Collections.Generic;
using System.Text;

namespace Nautilus.Core.Models
{
    public enum StepTypes { None = 0, Database = 1, WebService = 2 }
    public enum SQLDatabaseType { None = 0, MsSql = 1, Oracle = 2, Mysql = 3 }
    public enum SQLStepProcessTypes { None = 0, Query = 1, StoreProcedure = 2, Function = 3, View = 4 }
    public enum SQLQueryTypes { None = 0, Insert = 1, Select = 2, Update = 3, Delete = 4 }

    public enum ServisType {  SQL = 0,SOAP = 1, XML = 2, JSON = 3 }
    public enum CriteriaOperator
    {
        Equal = 0,
        Between = 1,
        GreaterThanOrEqual = 2,
        LesserThanOrEqual = 3,
        Like = 4,
        NotEqual = 5
    }
}
