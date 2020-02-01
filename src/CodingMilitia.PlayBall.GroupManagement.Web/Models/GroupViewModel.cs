// // GroupViewModel.cs
// // Amin jegham
// // 2/1/2020
using System;
namespace CodingMilitia.PlayBall.GroupManagement.Web.Models
{
    public class GroupViewModel
    {
        public GroupViewModel()
        {

        }

        public GroupViewModel(long _id, string _name)
        {
            Id = _id;
            Name = _name;
        }

        public long Id { get; set; }
        public string Name { get; set; }
    }
}
