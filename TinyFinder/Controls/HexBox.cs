﻿using System;
using System.Windows.Forms;

namespace TinyFinder
{
    //Credits to wwwwwwzx
    public class HexBox : MaskedTextBox
    {
        public HexBox()
        {
            Mask = "AAAAAAAA";
            TextAlign = HorizontalAlignment.Right;
            Size = new System.Drawing.Size(63, 22);
        }

        public uint Value
        {
            get => uint.TryParse(Text, System.Globalization.NumberStyles.HexNumber, null, out uint value) ? value : 0;
            set => Text = value.ToString("X" + Mask.Length.ToString());
        }

        protected override void OnEnter(EventArgs e)
        {
            base.OnEnter(e);
            Focus();
            SelectAll();
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            if (SelectionStart > Text.Length)
                SelectionStart = Text.Length;

            if (e.KeyChar == ' ') e.KeyChar = (char)0;

            if (SelectionStart < Mask.Length)
            {
                if (Mask[SelectionStart].Equals('A'))
                {
                    if (e.KeyChar != (char)Keys.Back && !char.IsControl(e.KeyChar))
                    {
                        if ((e.KeyChar >= 'a') && (e.KeyChar <= 'f'))
                        {
                            e.KeyChar = char.ToUpper(e.KeyChar);
                        }
                        else if (((e.KeyChar >= 'A') && (e.KeyChar <= 'F')) ||
                                 ((e.KeyChar >= '0') && (e.KeyChar <= '9')))
                        {
                        }
                        else
                            e.KeyChar = (char)0;
                    }
                }
            }
            base.OnKeyPress(e);
        }

        protected override void OnTextChanged(EventArgs e)
        {
            string replace = "";
            for (int charPos = 0; charPos < Text.Length; charPos++)
            {
                if (Mask[charPos].Equals('A'))
                {
                    if (((Text[charPos] >= 'a') && (Text[charPos] <= 'f')) ||
                        ((Text[charPos] >= 'A') && (Text[charPos] <= 'F')) ||
                        ((Text[charPos] >= '0') && (Text[charPos] <= '9')))
                    {
                        replace = replace + Text[charPos];
                    }
                }
            }
            Text = replace;

            base.OnTextChanged(e);
        }
    }
}