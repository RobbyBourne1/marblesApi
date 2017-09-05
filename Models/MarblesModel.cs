using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace marblesApi.Models
{
    public class MarblesModel 
    {
        public int Id { get; set; }
        public string Color { get; set; }
        public MarblesModel()
        {
            
        }

        public List<MarblesModel> MarbleBag()
        {
            var MarbleList= new List<MarblesModel>();
            var Blue = new MarblesModel
            {
                Id = 1,
                Color = "Blue"
            };

             var Green = new MarblesModel
            {
                Id = 2,
                Color = "Green"
            };

             var Yellow = new MarblesModel
            {
                Id = 3,
                Color = "Yellow"
            };

             var Red = new MarblesModel
            {
                Id = 4,
                Color = "Red"
            };

            MarbleList.Add(Blue);
            MarbleList.Add(Green);
            MarbleList.Add(Yellow);
            MarbleList.Add(Red);
            return MarbleList;
        }
    }
}