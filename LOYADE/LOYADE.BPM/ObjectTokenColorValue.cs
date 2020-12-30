using System;
using System.ComponentModel;

namespace LOYADE.BPM
{
    public class ObjectTokenColorValue
    {
        public ObjectTokenColorValue()
        {
            
        }

        [
            DisplayName("Max Value"),
            CategoryAttribute("Data"),
            DescriptionAttribute("Max Value."),
            ReadOnlyAttribute(false)
        ]
        public decimal MaxValue
        {
            get;
            set;
        }

        [
            DisplayName("Min Value"),
            CategoryAttribute("Data"),
            DescriptionAttribute("Min Value."),
            ReadOnlyAttribute(false)
        ]
        public decimal MinValue
        {
            get;
            set;
        }

        [
            DisplayName("Initial Value"),
            CategoryAttribute("Data"),
            DescriptionAttribute("Initial Value."),
            ReadOnlyAttribute(false)
        ]
        public decimal InitialValue
        {
            get;
            set;
        }

        [
            DisplayName("Current Value"),
            CategoryAttribute("Data"),
            DescriptionAttribute("Current Value."),
            ReadOnlyAttribute(false)
        ]
        public decimal CurrentValue
        {
            get;
            set;
        }

        [
            DisplayName("Temp Value"),
            DescriptionAttribute("Temp Value."),
            ReadOnlyAttribute(true)
        ]
        public decimal TempValue
        {
            get;
            set;
        }

    }
}
