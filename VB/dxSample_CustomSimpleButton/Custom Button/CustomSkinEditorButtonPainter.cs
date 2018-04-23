using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.XtraEditors.Drawing;
using DevExpress.Skins;
using DevExpress.Utils.Drawing;

namespace dxSample_CustomSimpleButton.Custom_Button {
    public class CustomSkinEditorButtonPainter : SkinEditorButtonPainter {
        public CustomSkinEditorButtonPainter(DevExpress.Skins.ISkinProvider provider)
            : base(provider) {
        }
        public CustomSkinEditorButtonPainter(DevExpress.Skins.ISkinProvider provider, object OwnerButton)
            : base(provider) {
            Button = OwnerButton as CustomButton;
        }
        private CustomButton Button;
        private CustomStyle GetCustomStyle() {
            CustomStyle style;
            if (Button != null) {
                style = Button.CustomStyle;
            }            else {
                style = CustomStyle.Style1;
            }
            return style;
        }
        protected override SkinElement GetSkinElement(EditorButtonObjectInfoArgs e, DevExpress.XtraEditors.Controls.ButtonPredefines kind) {
            return base.GetSkinElement(e, kind);
        }
        protected override int CalcImageIndexCore(DevExpress.Utils.Drawing.ObjectState state) {
            var customStyle = GetCustomStyle();
            var startImageIndex = 0;
            switch (customStyle) {
                case CustomStyle.Style1:
                    startImageIndex = 0;
                    break;
                case CustomStyle.Style2:
                    startImageIndex = 6;
                    break;
                case CustomStyle.Style3:
                    startImageIndex = 12;
                    break;
            }
            var tempState = state & (~ObjectState.Selected);
            if (tempState == ObjectState.Disabled) {
                return startImageIndex + 3;
            }
            if ((tempState & ObjectState.Pressed) != 0) {
                return startImageIndex + 2;
            }
            if ((tempState & ObjectState.Hot) != 0) {
                return startImageIndex + 1;
            }
            if ((state & ObjectState.Selected) != 0) {
                if (info.Element == null || info.Element.Image == null || info.Element.Image.ImageCount < 5) {
                    return startImageIndex + 0;
                }
                return startImageIndex + 4;
            }
            return startImageIndex + 0;
        }
    }
}
