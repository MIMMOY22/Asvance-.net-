using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static SCS.Models.Model;

namespace SCS.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var h = new Index()
            {
                Welcome = "WELCOME TO",
                Title="Smart Car Service",
                Massage = "We are a full-service auto repair shop and tire dealer featuring a comprehensive" +
                " selection of tires from trusted names like Continental, General, and Hercules." +
                " No matter what you need, our team is committed to providing the best products and " +
                "services possible. We believe every service experience should be a positive one," +
                " and we go the extra mile to ensure your complete satisfaction. Our service professionals " +
                "include ASE-certified technicians, and we are both a certified NAPA AutoCare Center." +
                "\r\n\r\nWhether it's installing tires and performing a wheel alignment," +
                " replacing the brake pads and rotors, running a check engine diagnostic, or changing the oil," +
                " our qualified team will meet all your automotive service needs at our convenient location.",
            };

            Index[] ix = new Index[] { h };
            return View(ix);
        }

        public ActionResult Services()
        {
           

            var s1 = new Services()
            {
                Title = "Axle, CV Joint & Driveshaft Repair",
                Details = "Your vehicle’s axle, CV joint, and driveshaft components are integral to the performance and drivability of your vehicle.",
                Cost = "$80"
            };
            var s2 = new Services()
            {
                Title = "Belts & Hoses",
                Details = "Your vehicle’s belts and hoses are involved in processes within the cooling system, air conditioning system, charging system, and engine",
                Cost = "$50"
            };
            var s3 = new Services()
            {
                Title = "Brake Repair",
                Details = "A fully functioning brake system is crucial to your safety, the safety of your passengers, and the safety of other drivers on the road",
                Cost = "$90"
            };

            Services[] cs = new Services[] { s1, s2, s3 };
            return View(cs);
        }

        public ActionResult Teams()
        {
            var t1 = new Teams()
            {
                Name = "Johnny Welker ",
                Role = "Owner",
                Bio = "Johnny has always loved working with his hands and helping people in need." +
                " It’s only natural that Johnny became the fearless leader of JW Auto Care." +
                " He is a kind and honest person who works hard to provide and care for others." +
                " The skills he brings to the table are empathy and clear communication about the task at hand." +
                " If you are looking for an auto shop that is loyal to its customers, honest, and committed to high standards, you’ll be glad you chose Johnny Welker and his team.",
                
            };
            var t2 = new Teams()
            {
                Name = "Patrick F. ",
                Role= "Technician",
                Bio = "Patrick has been a member of our team for many years," +
                " and we can always count on this talented tech to provide quality craftsmanship every time." +
                " There is no problem he cannot tackle in regards to suspension issues," +
                " wheel alignment, engine repair, brake service, and automotive air conditioning systems." +
                " He is detail oriented, thorough, and is somewhat of a Renaissance man." +
                " When Patrick isn’t turning wrenches, he’s attending church with his sister," +
                " or being out in nature doing some scuba diving, tending to his garden, or playing golf.",

            };
            var t3 = new Teams()
            {
                Name = "Jeff W.",
                Role = "Advisor",
                Bio = "By day, Jeff Warner is an amazing Service Advisor who is glad to provide our customers" +
                " with excellent service. But by night, Jeff is a multi-talented guy who could be juggling" +
                " and riding a unicycle one minute, or working in his vintage t-shirt shop the next." +
                " Jeff is the true definition of a dependable, hard-working, and positive guy who makes work" +
                " fun for everyone around him. We’re not sure where he gets his boundless energy from." +
                " It could be the black coffee he drinks, or the pistachios he eats daily," +
                " or maybe it’s from watching his kids play sports.",

            };
            var t4 = new Teams()
            {
                Name = "Dave B.",
                Role = "Part-Time Driver",
                Bio = "With 50 years of his life dedicated to the automotive industry, " +
                "Dave brings a wealth of experience to the team. He is excellent at time management and" +
                " organizing tasks, which is an incredible asset as our shuttle driver." +
                " When Dave is not driving customers around, you might be able to look up in the sky and" +
                " see him flying his private plane.",

            };

            Teams[] ts = new Teams[] { t1, t2, t3,t4 };
            return View(ts);
        }
        public ActionResult Contact()
        {
            var c1 = new Contact()
            {
                Address = "3011 N. 73rd Street,Scottsdale, AZ 85251",
                Email = "scs@gmail.com",

            };

            Contact[] ct = new Contact[] { c1 };

            return View(ct);
        }
    }
}