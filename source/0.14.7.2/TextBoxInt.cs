﻿using SevenDaysSaveManipulator.GameData;
using System;

namespace SevenDaysProfileEditor.GUI
{
    public class TextBoxInt : TextBoxNum<int>
    {
        public override void Update(object sender, EventArgs e)
        {
            int newValue;

            if (int.TryParse(Text, out newValue))
            {
                if (newValue < min || newValue > max)
                {
                    newValue = Clamp(newValue);
                }

                value.Set(newValue);
                Text = value.Get().ToString();
            }

            else
            {
                Text = value.Get().ToString();
                Focus();
            }
        }

        public TextBoxInt(Value<int> value, int min, int max, int width) : base(value, min, max, width)
        {

        }
    }
}