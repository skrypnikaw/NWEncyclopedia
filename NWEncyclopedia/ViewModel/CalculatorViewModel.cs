using NWEncyclopedia.ViewModel.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NWEncyclopedia.View.Pages;
using System.Windows.Controls;
using System.Windows;
using System.Windows.Data;
using System.Globalization;
using System.Windows.Input;
using NWEncyclopedia.Infastructure.Commands;

namespace NWEncyclopedia.ViewModel
{
    internal class CalculatorViewModel : ViewModelBase
    {
        private int _x ;
        private int _z ;
        private int _y;
        private int _w ;

        private List<string> _nameOfFields;

        public int X
        {
            get => _x;
            set => Set(ref _x, value);
        }
        public int W
        {
            get => _w;
            set => Set(ref _w, value);
        }
        public int Z
        {
            get => _z;
            set => Set(ref _z, value);
        }
        public int Y
        {
            get => _y;
            set => Set(ref _y, value);
        }
        public List<string> NameOfFields
        {
            get => _nameOfFields;
            set => Set(ref _nameOfFields, value);
        }

        public CalculatorViewModel()
        {
            _nameOfFields = new List<string>
            {
                "Персонаж",
                "Чакра",
                "Шмот",
                "Бижутерия",
                "Мультипликатор"
            };

        }
    }
}
