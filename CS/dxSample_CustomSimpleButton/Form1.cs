using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using DevExpress.LookAndFeel;
using DevExpress.Skins;

namespace dxSample_CustomSimpleButton {
    public partial class Form1 : DevExpress.XtraEditors.XtraForm {
        public Form1() {
            InitializeComponent();
            InitCustomStyle();
        }
        private void InitCustomStyle() {
            customButton1.CustomStyle = Custom_Button.CustomStyle.Style1;
            customButton2.CustomStyle = Custom_Button.CustomStyle.Style2;
            customButton3.CustomStyle = Custom_Button.CustomStyle.Style3;
        }        
    }
}
