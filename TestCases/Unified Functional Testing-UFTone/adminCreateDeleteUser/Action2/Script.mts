Browser("PerformanceRating").Page("PerformanceRating").Link("Administration").Click @@ script infofile_;_ZIP::ssf1.xml_;_
Browser("PerformanceRating").Page("PerformanceRating").WebMenu("User management Metrics").Select "User management" @@ script infofile_;_ZIP::ssf2.xml_;_
Browser("PerformanceRating").Page("PerformanceRating_2").Link("Create a new user").Click @@ script infofile_;_ZIP::ssf3.xml_;_
Browser("PerformanceRating").Page("PerformanceRating_3").WebEdit("login").Set "usertest" @@ script infofile_;_ZIP::ssf4.xml_;_
Browser("PerformanceRating").Page("PerformanceRating_3").WebEdit("firstName").Set "usertest" @@ script infofile_;_ZIP::ssf5.xml_;_
Browser("PerformanceRating").Page("PerformanceRating_3").WebEdit("lastName").Set "usertest" @@ script infofile_;_ZIP::ssf6.xml_;_
Browser("PerformanceRating").Page("PerformanceRating_3").WebEdit("email").Set "usertest@mail.com" @@ script infofile_;_ZIP::ssf7.xml_;_
Browser("PerformanceRating").Page("PerformanceRating_3").WebList("authorities").Select "ROLE_USER" @@ script infofile_;_ZIP::ssf8.xml_;_
Browser("PerformanceRating").Page("PerformanceRating_3").WebButton("Save").Click @@ script infofile_;_ZIP::ssf9.xml_;_
Browser("PerformanceRating").Page("PerformanceRating_2").Link("Delete").Click @@ script infofile_;_ZIP::ssf10.xml_;_
Browser("PerformanceRating").Page("PerformanceRating_4").WebButton("Delete").Click @@ script infofile_;_ZIP::ssf11.xml_;_
