using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2_OOP
{
    internal class Car
    {
        #region Attributes
        int id;
        string model;
        double speed;
        #endregion


        #region Properties
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        #endregion

        #region Methods
        public override string ToString()
        {
            return $"Id : {id} \n Model : {model} \nSpeed : {speed}";
        } 
        #endregion

        #region Constractors
        public Car(int _id, string _model, double _speed)
        {
            id = _id;
            model = _model;
            speed = _speed;
            Console.WriteLine("ctor01");
        }
        /// Constractor Chaning
        public Car(int _id, string _model):this (_id, _model,180)
        {
            //id = _id;
            //model = _model;
            //speed = 200;
            Console.WriteLine("ctor02");
        }
        public Car(int _id):this(_id, "TESLA",250)
        {
            //id = _id;
            //model = "TESLA";
            //speed = 200;
            Console.WriteLine("ctor03");
        }
        public Car()
        {
            //Do Nothing
        } 
        #endregion

    }

	

}
