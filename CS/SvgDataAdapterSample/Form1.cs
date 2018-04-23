using DevExpress.XtraMap;
using System;
using System.Windows.Forms;
namespace SvgDataAdapterSample {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        #region #SvgFileDataAdapter
        private void Form1_Load(object sender, EventArgs e) {
            Uri baseUri = new Uri(System.Reflection.Assembly.GetExecutingAssembly().Location);
            map.Layers.Add(new VectorItemsLayer {
                Data = new SvgFileDataAdapter {
                    FileUri = new Uri(baseUri, "..\\..\\Data\\countries.svg")
                }
            });
        }
        #endregion #SvgFileDataAdapter
    }
}
