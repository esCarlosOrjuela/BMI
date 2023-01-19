using System;
namespace Code.MVVM.ViewModels
{
    public class BMIViewModel
    {
        public Models.BMIModel BMI { get; set; }

        public BMIViewModel()
        {
            BMI = new Models.BMIModel()
            {
                Height = 180,
                Weight = 73
            };
        }

    }
}

