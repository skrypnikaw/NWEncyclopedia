using NWEncyclopedia.Model;
using NWEncyclopedia.View.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;
using System.Threading.Tasks;
using NWEncyclopedia.ViewModel.Base;

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
            get { return _menuFields; }
            set { _menuFields = value; }
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
