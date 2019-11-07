namespace Fast_Food_Restaurant
{


    partial class QLCH_FAST_FOODDataSet
    {
        partial class CTHDDataTable
        {
        }

        partial class HOADONDataTable
        {
        }
    }
}

namespace Fast_Food_Restaurant.QLCH_FAST_FOODDataSetTableAdapters
{
    partial class NHANVIENTableAdapter
    {
    }

    partial class MONANTableAdapter
    {
    }

    public partial class CTHDTableAdapter {
        private static CTHDTableAdapter instance;

        public static CTHDTableAdapter Instance
        {
            get { if (instance == null) instance = new CTHDTableAdapter(); return instance; }

            private set { instance = value; }
        }
    }
}
