using System.Collections.Generic;

namespace Eterna.Models
{
    public static class Data
    {
        public static List<Service> Services = new List<Service>
        {
            new Service{Id=1,Name="Lorem Ipsum",Icon="bxl-dribbble",
                Title="Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi"},
            new Service{Id=2,Name="Sed ut perspiciatis",Icon="bx-file",
                Title="Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore"},
            new Service{Id=3,Name="Magni Dolores",Icon="bx-tachometer",
                Title="Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia"},
            new Service{Id=4,Name="Nemo Enim",Icon="bx-world",
                Title="At vero eos et accusamus et iusto odio dignissimos ducimus qui blanditiis"},
            new Service{Id=5,Name="Dele cardo",Icon="bx-slideshow",
                Title="Quis consequatur saepe eligendi voluptatem consequatur dolor consequuntur"},
            new Service{Id=6,Name="Divera don",Icon="bx-arch",
                Title="Modi nostrum vel laborum. Porro fugit error sit minus sapiente sit aspernatur"},
        };

        public static List<Feature> Features = new List<Feature>()
        {
                new Feature{Id = 1,Title = "Service 1",Desc="Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi 1",Icon="<i class=\"bi bi-card-checklist\"></i>"},
                new Feature{Id = 2,Title = "Service 2",Desc="Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi 2",Icon="<i class=\"bi bi-bar-chart\"></i>"},
                new Feature{Id = 3,Title = "Service 3",Desc="Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi 3",Icon="<i class=\"bi bi-binoculars\"></i>"},
        };

        public static List<Slider> Slider = new List<Slider>()
        {
                new Slider{Id = 1,Title = "Eterna",Desc="Ut velit est quam dolor ad a aliquid qui aliquid. Sequi ea ut et est quaerat sequi nihil ut aliquam. Occaecati alias dolorem mollitia ut. Similique ea voluptatem. Esse doloremque accusamus repellendus deleniti vel. Minus et tempore modi architecto.",Img="slide-1.jpg"},
                new Slider{Id = 2,Title = "Ipsum Dolor",Desc="Ut velit est quam dolor ad a aliquid qui aliquid. Sequi ea ut et est quaerat sequi nihil ut aliquam. Occaecati alias dolorem mollitia ut. Similique ea voluptatem. Esse doloremque accusamus repellendus deleniti vel. Minus et tempore modi architecto.", Img="slide-2.jpg"},
                new Slider{Id = 3,Title = "Dime Lara",Desc="Ut velit est quam dolor ad a aliquid qui aliquid. Sequi ea ut et est quaerat sequi nihil ut aliquam. Occaecati alias dolorem mollitia ut. Similique ea voluptatem. Esse doloremque accusamus repellendus deleniti vel. Minus et tempore modi architecto.", Img="slide-3.jpg"},
        };
        public static List<Team> Teams = new List<Team>()
        {
                new Team{Id = 1, Img = "team-1.jpg", Name = "Walter White", Position = "Chief Executive Officer",
                    Desc = "Magni qui quod omnis unde et eos fuga et exercitationem. Odio veritatis perspiciatis quaerat qui aut aut aut"},
                new Team{Id = 2, Img = "team-2.jpg", Name = "Sarah Jhinson", Position = "Product Manager",
                    Desc = "Repellat fugiat adipisci nemo illum nesciunt voluptas repellendus. In architecto rerum rerum temporibus"},
                new Team{Id = 3, Img = "team-3.jpg", Name = "William Anderson", Position = "CTO",
                    Desc = "Voluptas necessitatibus occaecati quia. Earum totam consequuntur qui porro et laborum toro des clara"}
        };


    }
}
