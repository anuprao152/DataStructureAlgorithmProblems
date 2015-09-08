
var Home = (function () {

    //private variables
    var aboutme = {
        EduDetail: "I am a graduate of the Rochester Institute of Technology at Rochester with MS degree in Computer Science and the Sardar Patel University with BE degree in Computer Engineering.",
        CurWork: "I am currently working as a Software Engineer II at the AIR Worldwide, Boston. I desing, develope, test and release code.",
        qualification: "My qualification includes excellent development skills, including front-end and back-end. I possess strong development skills, am detail-oriented, and an effective team player as well as responsible and reliable on individual projects."
    }

    var education = [
        {
            Degree: "Master in Computer Science",
            College: "Rochester Institute of Technology",
            GPA: "3.02"
        },
        {
            Degree: "Bachelor in Computer Engineering",
            College: "BVM Eng College, Sardar Patel University",
            GPA: "3.12"
        }
    ]

    var skills = {
        "tech": [".Net", "C#", "MVC", "WPF", "MVVM", "WCF"],
        "front-end": ["JavaScript", "Jquery", "HTML", "CSS", "AJax"],
        "Database": ["SQL Server"],
        "working-Knowladge": ["Angular.js", "Node.js"]
    }

    var downloads= [
        {
            resume:"..\\Content\\Docs\\ARao.pdf",
        },
        {
            capstone:"..\\Content\\Docs\\ARaoCapstone.pdf"
        }
    ]
    var professional = [
        {
            Position: "Software Engineer II",
            Company: "AIR Worldwide",
        },
        {
            Position: "Web Developer",
            Company: "Amsterdam Printing",
        },
        {
            Position: "Software Engineer Co-op",
            Company: "Direct 2 Market Sales Solution"
        },
        {
            Position: "Software Developer Co-op",
            Company: "System Development Group"
        },

    ]

    //Return API to Expose
    return {
        AboutMe: aboutme,
        Education: education,
        Skills: skills,
        Professional: professional,
        Downloads:downloads,
    }
}())

$(document).ready(function () {
    $("#EduDetail").html(Home.AboutMe.EduDetail);
    $("#CurWork").html(Home.AboutMe.CurWork);
    $("#qualification").html(Home.AboutMe.qualification);

    //Professional Experience
    for (var i = 1; i <= Home.Professional.length; i++) {
        $("#professional p:nth-child(" + i + ")").html(Home.Professional[i - 1].Position + "<br>" + Home.Professional[i - 1].Company);
    }
 
    //Education
    for (var i = 1; i <= Home.Education.length; i++) {
        $("#Edu p:nth-child(" + i + ")").html(Home.Education[i - 1].Degree + "<br>" + Home.Education[i - 1].College)// + "<br>" + "GPA - " + Home.Education[i - 1].GPA);
    }

   
    $("#tech").html(function () {
            var s = '<ul>';
             for (var i = 0; i < Home.Skills.tech.length; i++) {
                 s = s + '<li>' + Home.Skills.tech[i] + "</li>";
             }
             s = s + '</ul>';
             return s;
    });

    $("#front-end").html(function () {
        var s = '<ul>';
        for (var i = 0; i < Home.Skills["front-end"].length; i++) {
            s = s + '<li>' + Home.Skills["front-end"][i] + "</li>";
        }
        s = s + '</ul>';
        return s;
    });

    $("#Database").html(function () {
        var s = '<ul>';
        for (var i = 0; i < Home.Skills.Database.length; i++) {
            s = s + '<li>' + Home.Skills.Database[i] + "</li>";
        }
        s = s + '</ul>';
        return s;
    });

    $("#working-Knowladge").html(function () {
        var s = '<ul>';
        for (var i = 0; i < Home.Skills["working-Knowladge"].length; i++) {
            s = s + '<li>' + Home.Skills["working-Knowladge"][i] + "</li>";
        }
        s = s + '</ul>';
        return s;
    });

    $("#ResumeDiv a").attr("href", Home.Downloads[0].resume);

}
)