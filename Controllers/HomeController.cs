using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Models;

namespace Portfolio.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            var skills = new List<Skill>
            {
                new Skill { Name = "ASP.NET Core", Level = 95 },
                new Skill { Name = "Entity Framework Core", Level = 90 },
                new Skill { Name = "C# Programming", Level = 92 },
                new Skill { Name = "SQL Server", Level = 88 },
                new Skill { Name = "API Development", Level = 85 },
                new Skill { Name = "MVC Architecture", Level = 90 }
            };

            var achievements = new List<Achievement>
            {
                new Achievement {
                    Icon = "Code",
                    Title = ".NET Solutions Architect",
                    Description = "Designed scalable .NET Core applications across multiple domains"
                },
                new Achievement {
                    Icon = "Server",
                    Title = "Backend Development",
                    Description = "Implemented REST APIs with JWT, middleware, and async processing"
                },
                new Achievement {
                    Icon = "Database",
                    Title = "Database Design",
                    Description = "Expertise in SQL Server procedures, indexing, and normalization"
                },
                new Achievement {
                    Icon = "Award",
                    Title = "Certified .NET Developer",
                    Description = "Microsoft-certified in ASP.NET and Azure fundamentals"
                }
            };

            ViewData["Skills"] = skills;
            ViewData["Achievements"] = achievements;

            return View();
        }

        public IActionResult Services()
        {
            var services = new List<Service>
    {
        new Service {
            Icon = "LayoutDashboard",
            Title = "Web App Development",
            Description = "Building full-stack web apps with .NET Core, MVC, and responsive frontends.",
            Features = new List<string> { "ASP.NET Core MVC", "Tailwind CSS / Bootstrap", "Razor Views", "Admin Dashboards" }
        },
        new Service {
            Icon = "Link",
            Title = "RESTful API Services",
            Description = "Developing secure and scalable APIs for mobile/web integration using .NET Web API.",
            Features = new List<string> { "JWT Authentication", "Swagger Documentation", "Versioning", "Exception Handling" }
        },
        new Service {
            Icon = "Database",
            Title = "Database Development",
            Description = "Expertise in designing relational databases and optimizing performance.",
            Features = new List<string> { "SQL Server", "Stored Procedures", "EF Core Migrations", "Data Seeding" }
        },
        new Service {
            Icon = "Cloud",
            Title = "Deployment & DevOps",
            Description = "Deploying .NET apps on IIS, Azure, and integrating CI/CD pipelines.",
            Features = new List<string> { "GitHub Actions", "Azure App Service", "Docker Support", "Logging with Serilog" }
        },
        new Service {
            Icon = "PenTool",
            Title = "UI/UX Designing",
            Description = "Designing engaging and user-friendly interfaces that enhance the user experience across web and mobile platforms.",
            Features = new List<string> { "Figma/Wireframes", "Responsive Design", "User Journey Mapping", "Interactive Prototypes" }
        },
        new Service {
            Icon = "Brush",
            Title = "Logo Designing",
            Description = "Creating visually impactful and brand-specific logos that leave a lasting impression.",
            Features = new List<string> { "Custom Logo Concepts", "Vector Files", "Revisions Included", "Brand Guidelines (Optional)" }
        },
        new Service {
            Icon = "Globe",
            Title = "Domain & Hosting Services",
            Description = "Helping businesses get online with domain registration and reliable hosting solutions.",
            Features = new List<string> { "Domain Purchase", "Shared/VPS Hosting", "Email Setup", "SSL Certificate Installation" }
        }
    };

            ViewData["Services"] = services;
            return View();
        }

        public IActionResult Projects()
        {
            var projects = new List<Project>
    {
        new Project {
            Title = "EdTech Management System",
            Category = "Education",
            Icon = "GraduationCap",
            Description = "Developed a role-based .NET Core MVC system to manage students, courses, attendance, and reports.",
            Technologies = new List<string> { ".NET Core", "EF Core", "Razor", "SQL Server" },
            Achievements = new List<string> {
                "Reduced manual workload by 60%",
                "Integrated role-based authorization",
                "Implemented dynamic report card generation",
                "Handled 10K+ student records efficiently"
            },
            TestingScope = new List<string> {
                "CRUD Operations",
                "Role-Based Access",
                "Attendance Tracking",
                "Grade Management"
            },
            Confidential = false
        },
        new Project {
            Title = "HRMS Attendance System",
            Category = "Enterprise",
            Icon = "Clock",
            Description = "Created an attendance management system with calendar view, punch-in/out, and leave tracking.",
            Technologies = new List<string> { ".NET 6", "JavaScript", "FullCalendar", "SQL" },
            Achievements = new List<string> {
                "Integrated selfie + location tracking",
                "Custom filters for date-wise, weekly, and monthly reports",
                "FullCalendar view with absence and warning logic"
            },
            TestingScope = new List<string> {
                "Authentication & Role Management",
                "Calendar Attendance UI",
                "Leave Application",
                "Email Alerts"
            },
            Confidential = false
        },
        new Project {
            Title = "Xpress Logistics App",
            Category = "Logistics",
            Icon = "Truck",
            Description = "Built a logistics management system in ASP.NET MVC for shipment tracking, warehouse inventory, and delivery management.",
            Technologies = new List<string> { "ASP.NET MVC", "SQL Server", "jQuery", "Bootstrap" },
            Achievements = new List<string> {
                "Live tracking of parcels and fleet",
                "Warehouse-to-delivery workflow automation",
                "Role-wise dashboards and dispatch summary reports"
            },
            TestingScope = new List<string> {
                "Shipment Tracking",
                "Fleet Management",
                "Role-Based Access",
                "Reporting & Notifications"
            },
            Confidential = false
        },
        new Project {
            Title = "EdTech LMS – Lead Management",
            Category = "Education",
            Icon = "Users",
            Description = "Developed a lead and subscription management system using ASP.NET MVC integrated with RESTful APIs.",
            Technologies = new List<string> { "ASP.NET MVC", "Web API", "Entity Framework", "SQL Server" },
            Achievements = new List<string> {
                "Streamlined lead assignment and tracking",
                "Integrated with external lead APIs (JustDial, IndiaMART)",
                "Excel bulk upload and filtering",
                "SMS/email notification system"
            },
            TestingScope = new List<string> {
                "Lead Capture & Follow-up",
                "Subscription Plan Management",
                "API Integration & Sync",
                "Performance Dashboard"
            },
            Confidential = false
        },
        new Project {
            Title = "School Management System",
            Category = "Education",
            Icon = "School",
            Description = "Comprehensive web-based school ERP built using ASP.NET Core MVC to manage academics, staff, and student information.",
            Technologies = new List<string> { "ASP.NET Core MVC", "EF Core", "Razor Pages", "SQL Server" },
            Achievements = new List<string> {
                "Centralized dashboard for admin, teacher, and parent roles",
                "Dynamic class-wise attendance and marks entry",
                "Custom report cards with grading scales",
                "Photo upload and document verification module"
            },
            TestingScope = new List<string> {
                "Student Management",
                "Teacher & Staff Roles",
                "Attendance & Grades",
                "Reports & Notifications"
            },
            Confidential = false
        }
    };

            ViewData["Projects"] = projects;
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Contact(ContactFormModel model)
        {
            if (ModelState.IsValid)
            {
                // Process form submission (send email, save to DB, etc.)
                TempData["Message"] = "Thank you! Your message has been sent successfully.";
                return RedirectToAction("Contact");
            }
            return View(model);
        }
    }
}
