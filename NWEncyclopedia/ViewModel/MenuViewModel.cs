using NWEncyclopedia.Model;
using NWEncyclopedia.View.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;
using System.Threading.Tasks;
using NWEncyclopedia.ViewModel.Base;
using System.Windows.Data;
using System.Globalization;

namespace NWEncyclopedia.ViewModel
{
    internal class MenuViewModel : ViewModelBase
    {
        private string _titleMenu;

        private List<string> _menuFields;

        public string TitleMenu
        {
            get => _titleMenu;
            set => Set(ref _titleMenu, value);
        }

        public List<string> MenuFields
        {
            get => _menuFields;
            set => Set(ref _menuFields, value);
        }
        public MenuViewModel()
        {
            _titleMenu = "Меню";
            _menuFields = new List<string>
            {
                "Правила Группы",
                "Каталог",
                "Гайды",
                "Таблицы",
                "Серверы",
                "Калькулятор"
            };
        }

       
    }
}
