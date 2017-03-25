using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.BO
{
    public class PersonalInfo
    {
        public int Weight { get; set; }
        public int Height { get; set; }
        private float _BMI { get; set; }
        public float BMI
        {
            get
            {
                //計算BMI
                Calculate();
                return _BMI;
            }
        }


        public float Calculate()
        {
            //如果型別轉成int就會計算錯誤
            float height = (float)Height / 100;
            //BMI=體重(kg) / 身高(m)^2
            _BMI = Weight / (height * height);
            //回傳
            return _BMI;
        }
    }
}