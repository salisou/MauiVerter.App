using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using UnitsNet;

namespace MauiVerter.MVVM.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public class ConverterViewModel
    {
        public string QuantityName { get; set; }
        public ObservableCollection<string> FromMeasures { get; set; }
        public ObservableCollection<string> ToMeasures { get; set; }
        public string CurrentFromMeasures { get; set; }
        public string CurrentToMeasures { get; set; }
        public double FormValue { get; set; } = 1;
        public double ToValue { get; set; }
        public ICommand ReturnCommand =>
            new Command(() =>
            {
                Convert();
            });

        public ConverterViewModel(string quantityName) 
        {
            QuantityName = quantityName;
            FromMeasures = LoadMeasure();
            ToMeasures = LoadMeasure();
            CurrentFromMeasures = FromMeasures.FirstOrDefault();
            CurrentToMeasures = ToMeasures.Skip(1).FirstOrDefault();
            Convert();
        }

        public void Convert()
        {
            var result = UnitConverter.ConvertByName(FormValue, QuantityName, CurrentFromMeasures, CurrentToMeasures);

            ToValue = result;
        }

        private ObservableCollection<string> LoadMeasure()
        {
            var types = 
                Quantity.Infos
                .FirstOrDefault(x => x.Name == QuantityName)
                .UnitInfos
                .Select(u => u.Name)
                .ToList();

            return new ObservableCollection<string>(types);
        }
    }
}
