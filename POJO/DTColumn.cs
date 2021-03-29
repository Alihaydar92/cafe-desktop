using System;

namespace Cafe.POJO
{
    class DTColumn
    {
        private string columnName;
        private string columnCaption;
        private Type type;
        private bool columnVisible;
        private int minimumWidth;
        private string expression;

        public DTColumn(string colName, String colCaption, Type colType, bool colVisible, int colMinWidth,string colExpression)
        {
            columnName = colName;
            columnCaption = colCaption;
            type = colType;
            columnVisible = colVisible;
            minimumWidth = colMinWidth;
            Expression = colExpression;
        }

        public string ColumnName { get => columnName; set => columnName = value; }
        public string ColumnCaption { get => columnCaption; set => columnCaption = value; }
        public Type Type { get => type; set => type = value; }
        public bool ColumnVisible { get => columnVisible; set => columnVisible = value; }
        public int MinimumWidth { get => minimumWidth; set => minimumWidth = value; }
        public string Expression { get => expression; set => expression = value; }

        public override string ToString()
        {
            return ColumnName;
        }
    }
}
