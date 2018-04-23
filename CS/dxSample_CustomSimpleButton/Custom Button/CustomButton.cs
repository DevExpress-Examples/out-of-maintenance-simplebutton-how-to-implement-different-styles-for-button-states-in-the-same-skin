using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.XtraEditors;

namespace dxSample_CustomSimpleButton.Custom_Button {
    [ToolboxItem(true)]
    internal class CustomButton : SimpleButton {
        protected override DevExpress.XtraEditors.ViewInfo.BaseStyleControlViewInfo CreateViewInfo() {
            return new CustomSimpleButtonViewInfo(this);
        }
        private CustomStyle _CustomStyle = CustomStyle.Style1;
        public CustomButton() {
            AssignCustomImage();
        }
        public void AssignCustomImage() {
            var skin = GetCurrentSkin();
            var img = GetImage();
            if (img != null) {
                SetElementImage(skin, img);
            }
        }
        public CustomStyle CustomStyle {
            get {
                return _CustomStyle;
            }
            set {
                _CustomStyle = value;
            }
        }
        private Image GetImage() {
            return global::dxSample_CustomSimpleButton.Properties.Resources.NewButton;
        }
        public void SetElementImage(Skin currentSkin, Image image) {
            var element = currentSkin[CommonSkins.SkinButton];
            element.SetActualImage(image, false);
            element.Image.ImageCount = 18;
        }
        private Skin GetCurrentSkin() {
            return CommonSkins.GetSkin(UserLookAndFeel.Default.ActiveLookAndFeel);
        }
    }
}
