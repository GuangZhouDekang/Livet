﻿//このコードはT4 Templateによって自動生成されています。

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Windows;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Controls.Primitives;
using System.ComponentModel;
using System.Windows.Interop;
using System.Windows.Data;
using System.Windows.Markup;
using System.Windows.Documents.Serialization;
using System.Windows.Input;
using System.Windows.Media.Animation;
using System.Windows.Media;
using System.Windows.Media.TextFormatting;
using System.Windows.Annotations;
using System.Windows.Ink;
using System.Windows.Automation.Peers;
using System.Windows.Markup.Localizer;
using System.Windows.Media.Imaging;
using System.IO.Packaging;
using System.Security.RightsManagement;
using System.Windows.Threading;
using System.Windows.Media.Effects;
using System.Windows.Shell;
using System.Security.Permissions;
using System.Windows.Annotations.Storage;
using System.Diagnostics;

namespace Livet.Converters
{
	/// <summary>
    /// TextAlignment列挙体とbool値の相互変換を行うIValueConverterです。
    /// </summary>
    public class TextAlignmentAndBooleanConverter : IValueConverter
    {
        //VM→View
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (!(value is bool)) throw new ArgumentException();

            if ((bool)value)
            {
                if (_isConvertWhenTrueSet)
                {
                    return ConvertWhenTrue;
                }
            }
            else
            {
                if (_isConvertWhenFalseSet)
                {
                    return ConvertWhenFalse;
                }
            }

            return DependencyProperty.UnsetValue;
        }

        private bool _isConvertWhenTrueSet;
        private TextAlignment _convertWhenTrue;
		/// <summary>
        /// ソース値がTrueの際にどのTextAlignment列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public TextAlignment ConvertWhenTrue
        {
            get
            {
                return _convertWhenTrue;
            }
            set
            {
                _convertWhenTrue = value;
                _isConvertWhenTrueSet = true;
            }
        }

        private bool _isConvertWhenFalseSet;
        private TextAlignment _convertWhenFalse;
		/// <summary>
        /// ソース値がFalseの際にどのTextAlignment列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public TextAlignment ConvertWhenFalse
        {
            get
            {
                return _convertWhenFalse;
            }
            set
            {
                _convertWhenFalse = value;
                _isConvertWhenFalseSet = true;
            }
        }

        //View→VM
        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (!(value is TextAlignment)) throw new ArgumentException();

            var enumValue = (TextAlignment)value;

			switch(enumValue.ToString())
			{
				case "Left":
					if (_isConvertBackWhenLeftSet)
					{
						return ConvertBackWhenLeft;
					}
					break;
				case "Right":
					if (_isConvertBackWhenRightSet)
					{
						return ConvertBackWhenRight;
					}
					break;
				case "Center":
					if (_isConvertBackWhenCenterSet)
					{
						return ConvertBackWhenCenter;
					}
					break;
				case "Justify":
					if (_isConvertBackWhenJustifySet)
					{
						return ConvertBackWhenJustify;
					}
					break;
				default:
					throw new ArgumentException();
			}

            if (_isConvertBackDefaultBooleanValueSet)
            {
                return ConvertBackDefaultBooleanValue;
            }

            return DependencyProperty.UnsetValue;
        }

        private bool _isConvertBackDefaultBooleanValueSet;
        private bool _convertBackDefaultBooleanValue;
		/// <summary>
        /// TextAlignmentの値をbool値に変換する際のデフォルト値を指定、または取得します。
        /// </summary>
        public bool ConvertBackDefaultBooleanValue
        {
            get
            {
                return _convertBackDefaultBooleanValue;
            }
            set
            {
                _convertBackDefaultBooleanValue = value;
				_isConvertBackDefaultBooleanValueSet = true;
            }
        }

        private bool _isConvertBackWhenLeftSet;
        private bool _convertBackWhenLeft;
		/// <summary>
        /// TextAlignmentの値がLeftの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenLeft
        {
            get
            {
                return _convertBackWhenLeft;
            }
            set
            {
                _convertBackWhenLeft = value;
                _isConvertBackWhenLeftSet = true;
            }
        }
        private bool _isConvertBackWhenRightSet;
        private bool _convertBackWhenRight;
		/// <summary>
        /// TextAlignmentの値がRightの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenRight
        {
            get
            {
                return _convertBackWhenRight;
            }
            set
            {
                _convertBackWhenRight = value;
                _isConvertBackWhenRightSet = true;
            }
        }
        private bool _isConvertBackWhenCenterSet;
        private bool _convertBackWhenCenter;
		/// <summary>
        /// TextAlignmentの値がCenterの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenCenter
        {
            get
            {
                return _convertBackWhenCenter;
            }
            set
            {
                _convertBackWhenCenter = value;
                _isConvertBackWhenCenterSet = true;
            }
        }
        private bool _isConvertBackWhenJustifySet;
        private bool _convertBackWhenJustify;
		/// <summary>
        /// TextAlignmentの値がJustifyの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenJustify
        {
            get
            {
                return _convertBackWhenJustify;
            }
            set
            {
                _convertBackWhenJustify = value;
                _isConvertBackWhenJustifySet = true;
            }
        }
    }
}