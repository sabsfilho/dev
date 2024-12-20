const CtMain = function(){

    const experience = {
        projs: [
            {
                tit: 'Put.Call.Bot, Quant Trading System Fintech, RJ-Brazil<br/>Working remote since September 2013<br/>JavaScript C# .NET Full Stack Developer',
                bdy: 'exp_pcb'
            },
            {
                tit: 'Box.Brazil, Logistics Startup, RJ-Brazil<br/>October 2010 - September 2013<br/>JavaScript C# .NET Full Stack Developer',
                bdy: 'exp_bxbr'
            },
            {
                tit: 'Itau Previtec, Banking, RJ-Brazil<br/>July 2000 - October 2010<br/>Project Manager and Senior Software Engineer',
                bdy: 'exp_itprv'
            }
        ]
    },
    buildImagesPanel = (k, arr) => {
        const xs = ['<div class="ImagesPanel">'];
        arr.forEach(x=>xs.push(`<div><div>${x[0]}</div><img src="assets/img/${k}/${x[1]}.jpg" /></div>`));
        xs.push('</div>')
        return xs.join('')
    },
    showCase = {
        projs: [
            {
                tit: 'Full Stack, Product Development, <b>Quant Automated Trade System Platform</b>',
                projs: [
                    {p:'',u:'http://putcallbot.com/',k:'',n:'Put.Call.Bot Quant Trade System Platform',tags:'C#,.NET,T-SQL,HTML5,CSS,Javascript,jQuery,WebService API,FIX Protocol,Subversion,SQL SERVER,IIS,AWS Cloud',d:`
                    <div class="accord-subtit">Since 2013 as JavaScript C# .NET Full Stack Developer</div>
					<br>
					<p><img class="pcb-logo" src="assets/img/pcb/PCBFolders.jpg" alt="company logo" /></p>
					<p>Put.Call.Bot is a software solution that evaluates quantitative analysis from real time Bovespa exchange market data, sending buy and sell signals to brokers according to the algorithmic strategy chosen by the trader.</p>
					<p>By providing investment robots that operate 100% automatically, Put.Call.Bot positions itself at the forefront of the financial revolution, offering solutions that transcend traditional methods. These automated systems are designed to analyze real-time data, identify market opportunities, and execute transactions swiftly, all without human intervention.</p>
                    <p>This approach not only increases the effectiveness of operations but also significantly reduces the potential for errors resulting from impulsive or emotional decisions. The trust placed in Put Call Bot's sophisticated algorithms reflects the company's dedication to providing its clients with a safer, transparent, and more effective investment experience.</p>
					<p>This automated trading system is a very powerful no-code web platform that allows our clients to work from any web browser or device. It is designed to negotiate stocks, options, derivatives and future instruments in a low or high frequency trading way and manages day trade or swing trade positions as well.</p>
                    <p>The trader can work with virtual orders or set to route them to his broker, also one or more broker accounts can be saved and used.</p>
                    <p>Our platform allows the trader to create, debug, test, optimize, and execute trading robots in an exclusive environment totally independent from the production server, and also a development server can be requested to safely build and test their algorithms.</p>
                    <p>When the work is done, all these strategies can be published to production in the real world environment. The main purpose of PutCallBot is to replace the hard work of following the market tick by tick giving time to the trader to evaluate better strategies for his portfolio.</p>
					<p>Following this is a document that I made explaining this project better.<br>
					<a href="assets/doc/PutCallBot_v138_en.pdf">click here to open some pages of the Compliance Document sent to XP Broker in March, 2017</a>
					</p>
					<p>In the early days of this project, I made our electronic integration to the <b>XP Broker Electronic Trade System (ETS)</b> and the <b>Brazilian Bovespa Exchange Order Management System (OMS)</b> using the <b>Financial Information eXchange protocol (FIX)</b> which is an electronic communications protocol for international real-time exchange of information related to securities transactions and markets. As I have a strict budget for this project, I researched and luckily found a great 100% free and open source solution with a great community support. So, I decided to use the <a href="https://quickfixn.org/">QuickFIX/n</a> library which implements the <b>FIX</b> protocol on <b>.NET</b>. Later I also integrated our system with other electronic trading system providers as <a href="https://www.cedrotech.com/">Cedro Technologies</a>, <a href="https://www.metatrader5.com/">Metatrader</a> and <a href="https://www.nelogica.com.br/">Nelogica</a>, consuming their API's.</p>
					<p><i>I've also created an extensive document to help me guide my skeptical colleagues, who are Microsoft stack developers, to build the environment needed to deploy a <b>.NET 8 microservice to AWS Lambda Serverless Function</b>, using a Ubuntu/Linux distribution and the cost-effective <b>Graviton processor</b> based in the Arm64 architecture. Along this process, I realized that the installation and the related configuration using this architecture was a sort of problematic depending on the installation pathway chosen. So, I decided to describe the solutions that worked better for our development context and maybe could also help someone else outside our playground. My colleagues, who were once resistant, now are engaged and using this DevContainer development concept. To support some tasks presented in this guide, I've created some bash scripts running <b>.NET CLI</b> and <b>AWS CLI</b> commands. If you are interested, you can open this guide by <a target="_blank" href="https://docs.google.com/document/d/1Yg7iscwM2IChCxy66aYhOB4-kA_9cgu6XC3Ar5RNn5k/edit?usp=sharing">clicking here</a></i>.</p>
					<p><img class="TheManWhoSolvedTheMarketCover" src="assets/img/TheManWhoSolvedTheMarket.jpg">This project was inspired by the Renaissance Technologies Hedge Fund which was the first company using quantitative models derived from mathematical and statistical analysis in an Automated Trading System (ATS). Their Medallion fund has generated average annual returns of 66 percent.
					If you are even more interested about our project I recommend this book that tells the amazing story about Jim Simon, who is considered the greatest money maker in modern financial history.<br>					
					<a href="https://www.amazon.com/Man-Who-Solved-Market-Revolution/dp/073521798X">The Man Who Solved the Market: How Jim Simons Launched the Quant Revolution Hardcover - Amazon Store</a></p>					
${buildImagesPanel('pcb', 
    [
        ['Automated Trading System for Hedge Fund Managers', 'PCBDesk'],
        ['modernization project - working in progress, men at work', 'PutCallBotHighLevelModelDesign'],
        ['system oriented architecture and cloud native high level design after modernization <i>and traction (\'cause money talks...)</i>', 'PutCallBotSOAHighLevelDesign'],
        ['.NET 8 unmanaged code integration - third-party delphi dll 64 bits - ProfitChart by Nelogica', 'ProfitChartUnmanagedCodeIntegration'],
        ['the system general concept - legacy monolithic architecture - high level design for non-techies (stakeholders, customers)', 'SystemDesign'],
        ['XP Broker Eletronic Trading System (ETS) Integration', 'ETS_FIX_Protocol'],
        ['the future - machine learning predicting model with TensorFlow LSTM using Google Colab', 'LSTMPredictingModel'],
        ['a swing trade strategy shown by the portfolio manager screen','PortfolioManager'],
        ['a day trade strategy using automation and the manual place order screen','PlaceOrderWindow'],
        ['market data, bid and offer price, online position data and more on the multi view trading screen','TradingScreen'],
        ['trading speedometer measures the price sentiment and its oscillation in real time','Speedometer'],
        ['portfolio results against many financial benchmarks by the strategy performance chart','StrategyPerformanceChart'],
        ['BI chart report for candle pattern research','SimilarCandle'],
        ['no-code platform design - strategy configuration','NoCodePlatform'],
        ['candle strategy script builder with realtime parameter values view','CandleExpressionBuilder']
    ])}
<div class="pcb-logo"><div>Put.Call.Bot Technologies</div>
<img src="assets/img/pcb/PCBLogo.jpg" alt="company logo" /></div>`},
                ]
            },
            {
                tit: 'Backend, Software Architect, Platform Module, .NET 8, C#, GitHub, Docker, DevContainer, Microservice, AWS Lambda, AWS S3, <b>Cron Job Manager</b>',
                projs: [
                    {p:'',u:'https://github.com/sabsfilho/EC2Scheduler',k:'',n:'EC2Scheduler (click here to open GitHub project repository)',tags:'C#,.NET 8,GitHub,Docker,VS Code,DevContainer,.NET CLI,AWS CLI,NUnit,AWS Lambda,AWS S3,AWS EventBridge,AWS EC2,AWS Cloud',d:`
					<p>AWS Lambda Function microservice to control Cron Jobs and AWS EC2 resources.</p>
					<p><img class="pcb-logo" src="articles/AWSLambdaDockerInDockerGraviton/images/AWSLambdaAndDockerInDockerSmall.jpg" alt="AWSLambdaAndDockerInDockerSmall" /></p>
					<p>The purpose of this microservice is to control AWS Elastic Compute Cloud EC2 resources, executing Scheduled Tasks or Cron Jobs.</p>
					<p>It provides a pipeline to allow some infrastructure maintenance procedures to be executed by our internal services. I tailored this project to be public on my GitHub repository for training my colleagues. I didn't implement any internal pieces that would expose some complexities of our business logic.</p>
					<p>This project is also used as the Backend module by a Frontend .NET8 project, which is a Web Application written in Javascript and React, and using Tailwind.css. I am working on a public version to allow me to put it into my open GitHub repository and then release a more complete Full Stack system.</p>
					<p>I wrote an all-in-one guide to help me and my colleagues to create a straightforward walk through to create a boilerplate for AWS Lambda Serverless Function from Zero to Hero. using the cost effective Graviton Arm64 processor from a VS Code Docker In Docker Dev Container running on Linux/Ubuntu EC2 Instance. <a href="https://www.linkedin.com/pulse/publish-net-8-microservice-aws-lambda-function-using-cost-santos-vsiqe">Click here and check it out!</a></p>
					`}
				]
			},
            {
                tit: 'Backend, Software Design, Service Layer, <b>Redis</b>, .NET 8, C#, GitHub, Docker, DevContainer, Microservice, AWS Lambda, AWS API Gateway, AWS S3, <b>Geolocation API</b>',
                projs: [
                    {p:'',u:'https://github.com/sabsfilho/IPGeoGuard',k:'',n:'IPGeoGuard (click here to open GitHub project repository)',tags:'C#,.NET 8,Redis,GitHub,Docker,VS Code,DevContainer,.NET CLI,AWS CLI,AWS Lambda,AWS S3,AWS Cloud',d:`
					<p>AWS Lambda Function microservice to control IP requests and web resources using Geolocation by Country and City.</p>
					<p><img class="pcb-logo" src="assets/img/pcb/IPGeoGuard.jpg" alt="IPGeoGuard" /></p>
					<p>This project is a microservice that provides a Geolocation protection layer verifying an incoming request and using virtual geographic perimeters to determine if its IP address is allowed to access a restricted service resource. It is very useful when the ip address is available, but not the coordinate.</p>
					<p>Another great future is to be capable of showing audience locations to see where the biggest audience exists. It is possible to create reports grouping user traffic by country and city.</p>
					<p>These are the main targets of this project:
					<ul>
						<li>Block requests from restricted geographic areas</li>
						<li>Allow requests from permitted geographic areas</li>
						<li>Enable/disable features for specific regions</li>
						<li>Keep and report audience traffic by location (Country, City...)</li>
					</ul>
					</p>
					<p>This project is a .NET 8 microservice hosted in AWS Lambda Function and can be easily integrated consuming a file in GeoJSON format.</p>
					<p>The incoming request IP address is translated into a geographic location and verified in the whitelist or blacklist files configured by the system administrator.</p>
					<p>This IPGeoGuard microservice consumes the IP Geolocation API tool to determine a user's location and use the geolocation information.
					<a href="https://www.ip2location.io">IP2 Location API</a></p>
					<p>I created an AWS API Gateway to invoke the IP GeoGuard Lambda function using its REST API. Using AWS API Gateway provides a secure HTTP endpoint to invoke this Lambda function and it helps manage large volumes of calls by throttling traffic and automatically validating and authorizing API calls. So, it's good practice to implement this connectivity layer.</p>
					<p>In this project, for my experimental purposes, I am also using <a href="https://redis.io/">Redis Database, in-memory storage</a> to cache Geolocation metadata, so I can significantly reduce IP2Location API requests. Redis is the world's fastest in-memory database and extremely easy to integrate. For the sake of simplicity and seamless integration, I decided to use <a href="https://aws.amazon.com/memorydb/">AWS MemoryDB</a>, Redis OSS-compatible service for ultra-fast performance, but being aware of related infrastructure costs, a trade-off analysis is strongly recommended.</p>
					<p>I recently submitted this project to the <a href="https://contest.ip2location.com/#ipinfodb-invitation">IP2Location.io Programming Contest</a>. I found it would be a perfect opportunity to test my abilities, learn new techniques and share my knowledge.</p>
					<p><img class="pcb-logo" src="assets/img/pcb/IP2LocationContest.jpg" alt="IP2Location Contest" /></p>
					<p>I also created a minimal Web API project with ASP.NET Core. I named it SimpleApi and it is used solely for demonstration. I designed these functions:
					<ul>
					<li>GetCurrentTime => first check if the requested IP address can access this service using the IPGeoGuard. If it is allowed, then print the server current time. Otherwise, returns the region restriction warning message.</li>
					<li>GetMapViews => print the stored requested IPs aggregated  by Country and City.</li>
					<li>PutRestriction => set Country restriction for GetCurrentTime function.</li>
					<li>DeleteRestriction => remove Country restriction for GetCurrentTime function.</li>
					</ul>
					<img class="pcb-logo" src="assets/img/pcb/SimpleApiSwagger.jpg" alt="SimpleApiSwagger" />
					</p>
					`}
				]
			},
            {
                tit: 'Backend, Software Design, <b>WebSocket</b>, .NET 8, C#, GitHub, <b>Entity Framework</b>, Microservice, <b>Azure Web API</b>, <b>NoSQL Azure CosmosDB</b>, Parallel Programming, SOLID, SOC, <b>CryptoCurrency API</b>',
                projs: [
                    {p:'',u:'https://github.com/sabsfilho/CryptoCurrencyExchangeBroker',k:'',n:'CryptoCurrencyExchangeBroker on Azure (click here to open GitHub project repository)',tags:'C#,.NET 8,Azure WebAPI,WebSocket,EntityFramework,CosmosDB,GitHub,.NET CLI,Azure Cloud',d:`
					<p>Service Oriented Architecture using AZURE cloud resources.</p>
					<p><img class="pcb-logo" src="articles/CryptoCurrencyExchangeBroker/CryptoCurrencyExchangeBroker_1240.jpg" alt="CryptoCurrencyExchangeBroker_1240" /></p>
					<p>Recently at my current company, I implemented an agnostic cloud architecture solution using the DockerHub container repository to register some microservices images that could be published to our AWS or Azure cloud spaces. We are evaluating some AWS cost concerns.</p>
					<p>I have been using Azure cloud resources for my personal labs for about 3 years, and actually I really enjoy working with Azure solutions and even more because it can be easily integrated with Visual Studio and GitHub. They are also using amazing technologies such as Biceps for CI/CD deployment.</p>
					<p>So, inspired by this recent study, I decided to create on my Azure account a micro service project that should consume Azure resources, then I came up with this CryptoCurrency project to present to my fellows a simple way to learn a Websocket API server using .NET 8 and also Entity Framework consuming a NoSQL database, the Azure Cosmos DB, which is great for low latency performance.</p>
					<p>I developed this project based on Parallel Programming, SOLID, Clean Code, Object Oriented, Domain Driven Design and Keep It Simple Stupid (KISS) concepts. The persistence layer has an important abstraction that could allow me change the database management system without changing the business logic layer. The Entity Framework also helps to achieve this level of abstraction modeling the storage entities for us.</p>
					<p>
					<img class="pcb-logo" src="articles/CryptoCurrencyExchangeBroker/CryptoCurrencyExchangeBrokerHighLevelDesign.jpg" alt="CryptoCurrencyExchangeBroker" /<br/>
					<div>Project Highlights:</div>
					<ul>
						<li>CryptoCurrency .NET 8 Minimal API solution using the Bitstamp.net crypto exchange Websocket API.</li>
						<li>Adopted GitHub Actions CI/CD pipeline to Azure Web App and also consuming Azure Cosmos DB with Entity Framework.</li>
						<li>Enable/disable features for specific regions</li>
						<li>Development based on Parallel Programming, SOLID, Separation of Concerns, Clean Code, Object Oriented and Domain Driven Design best practices.</li>
					</ul>
					</p>
					<p>This project is a .NET 8 microservice hosted on my Azure account.</p>
					<p>This is the public API url:<br/>
					<a href="https://cryptocurrencyexchangebrokerapi20240930232221.azurewebsites.net/">https://cryptocurrencyexchangebrokerapi20240930232221.azurewebsites.net/</a><br/>
					<img class="pcb-logo" src="articles/CryptoCurrencyExchangeBroker/home-api.png" alt="HomeAPI" />
					</p>
					<p>As I am using my Azure account, I have to be very cautious about related cloud costs. So, I am using the FREE F1 plan that unfortunately takes a minute to warm up the service and also it has these constrains:<br/>
						<ul>
							<li>Limited compute and memory resources: The F1 plan provides a shared instance of a single CPU core and 1 GB of memory.</li>
							<li>Limited traffic: The F1 plan allows only up to 1 hour of CPU usage in a day.</li>
							<li>Limited features: The F1 plan does not include some features as auto-scaling.</li>
						</ul>
					</p>
					<p>I've created a GitHub Actions CI/CD pipeline to Azure Web App and I also configured it to be public. So, it's possible to consume this API using <a href="https://www.postman.com/">Postman</a> or <a href="https://swagger.io/tools/swagger-ui/">SWAGGER UI</a>.<br/>
						<img class="pcb-logo" src="articles/CryptoCurrencyExchangeBroker/SWAGGER_API.png" alt="SWAGGER_API" />
					</p>
					<p>I implemented an API function to create a very simple HTML to show the Crypto Coin Order Book. I simply put a head meta data tag to refresh the page each 5 seconds.<br/>
						<img class="pcb-logo" src="articles/CryptoCurrencyExchangeBroker/CryptoOrderBook_BTCUSD.jpg" alt="CryptoOrderBook_BTCUSD" />
					</p>
					`}
				]
			},
            {
                tit: 'Web Design & Style, HTML5, SCSS, Flexbox',
                k: 'rebrand/FreeCodeCamp/Certification/ResponsiveWebDesign',
                projs: [
                    {k:'AccessibilityQuiz',n:'Accessibility Quiz',tags:'HTML5,CSS,SCSS,Flexbox,CSS Grid',d:''},
                    {k:'BalanceSheet',n:'Balance Sheet',tags:'HTML5,CSS,SCSS,Flexbox,CSS Grid',d:''},
                    {k:'CatPainting',n:'Cat Painting',tags:'HTML5,CSS,SCSS,Flexbox,CSS Grid',d:''},
                    {k:'CitySkyline',n:'City Skyline',tags:'HTML5,CSS,SCSS,Flexbox,CSS Grid',d:''},
                    {k:'FerrisWheel',n:'Ferris Wheel',tags:'HTML5,CSS,SCSS,Flexbox,CSS Grid',d:''},
                    {k:'LandingPage',n:'Landing Page',tags:'HTML5,CSS,SCSS,Flexbox,CSS Grid',d:''},
                    {k:'Magazine',n:'Magazine',tags:'HTML5,CSS,SCSS,Flexbox,CSS Grid',d:''},
                    {k:'NutritionLabel',n:'Nutrition Label',tags:'HTML5,CSS,SCSS,Flexbox,CSS Grid',d:''},
                    {k:'Penguin',n:'Penguin',tags:'HTML5,CSS,SCSS,Flexbox,CSS Grid',d:''},
                    {k:'PhotoGallery',n:'Photo Gallery',tags:'HTML5,CSS,SCSS,Flexbox,CSS Grid',d:''},
                    {k:'Piano',n:'Piano',tags:'HTML5,CSS,SCSS,Flexbox,CSS Grid',d:''},
                    {u:'https://sabsfilho.github.io/dev/',n:'Portfolio Demo',tags:'HTML5,CSS,SCSS,Flexbox,CSS Grid',d:''},
                    {k:'RegistrationForm',n:'Registration Form',tags:'HTML5,CSS,SCSS,Flexbox,CSS Grid',d:''},
                    {k:'RothkoPainting',n:'Rothko Painting',tags:'HTML5,CSS,SCSS,Flexbox,CSS Grid',d:''},
                    {k:'SurveyForm',n:'SurveyForm',tags:'HTML5,CSS,SCSS,Flexbox,CSS Grid',d:''},
                    {k:'TechnicalDocumentation',n:'Technical Documentation',tags:'HTML5,CSS,SCSS,Flexbox,CSS Grid',d:''}
                ]
            },
            {
                tit: 'Javascript JSE6',
                k: 'rebrand/FreeCodeCamp/Certification/JavaScriptAlgorithmsAndDataStructures',
                projs: [
                    {k:'CashRegister/CashRegister',n:'CashRegister',tags:'JSE6',d:''},
                    {k:'CashRegister/DiceGame',n:'DiceGame',tags:'JSE6',d:''},
                    {k:'CashRegister/PlatformerGamer',n:'PlatformerGamer',tags:'JSE6',d:''},
                    {k:'CashRegister/ShoppingCart',n:'ShoppingCart',tags:'JSE6',d:''},
                    {k:'Palindrome/CalorieCounter',n:'CalorieCounter',tags:'JSE6',d:''},
                    {k:'Palindrome/DateFormatter',n:'DateFormatter',tags:'JSE6',d:''},
                    {k:'Palindrome/MusicPlayer',n:'MusicPlayer',tags:'JSE6',d:''},
                    {k:'Palindrome/PalindromeChecker',n:'PalindromeChecker',tags:'JSE6',d:''},
                    {k:'Palindrome/RolePlayingGame',n:'RolePlayingGame',tags:'JSE6',d:''},
                    {k:'PokemonSearchApp/fCCAuthorsPage',n:'fCCAuthorsPage',tags:'JSE6',d:''},
                    {k:'PokemonSearchApp/fCCForumLeaderboard',n:'fCCForumLeaderboard',tags:'JSE6',d:''},
                    {k:'PokemonSearchApp/PokemonSearchApp',n:'PokemonSearchApp',tags:'JSE6',d:''},
                    {k:'RomanNumeralConverter/DecimalToBinaryConverter',n:'DecimalToBinaryConverter',tags:'JSE6',d:''},
                    {k:'RomanNumeralConverter/FootballTeamCards',n:'FootballTeamCards',tags:'JSE6',d:''},
                    {k:'RomanNumeralConverter/RomanNumeralConverter',n:'RomanNumeralConverter',tags:'JSE6',d:''},
                    {k:'RomanNumeralConverter/TodoApp',n:'TodoApp',tags:'JSE6',d:''},
                    {k:'TelephoneNumberValidator/NumberSorter',n:'NumberSorter',tags:'JSE6',d:''},
                    {k:'TelephoneNumberValidator/SpamFilter',n:'SpamFilter',tags:'JSE6',d:''},
                    {k:'TelephoneNumberValidator/Spreadsheet',n:'Spreadsheet',tags:'JSE6',d:''},
                    {k:'TelephoneNumberValidator/StatisticsCalculator',n:'StatisticsCalculator',tags:'JSE6',d:''},
                    {k:'TelephoneNumberValidator/TelephoneNumberValidator',n:'TelephoneNumberValidator',tags:'JSE6',d:''},
                ]
            },
            {
                tit: 'Front End, React, Redux',
                k: 'rebrand/FreeCodeCamp/Certification/FrontEndDevelopment',
                projs: [
                    {k:'25-5-clock/dist',n:'25-5 Clock',tags:'HTML5,SCSS,JSE6,React,Redux',d:''},
                    {k:'drum-machine/dist',n:'Drum Machine',tags:'JSE6,React,Redux',d:''},
                    {k:'javascript-calculator/dist',n:'Calculator',tags:'JSE6,React,Redux',d:''},
                    {k:'random-quote-machine/dist',n:'Random Quote Machine',tags:'JSE6,React,Redux',d:''},
                    {k:'simple-react-markdown-previewer/dist',n:'Simple React Markdown Previewer',tags:'JSE6,React,Redux',d:''},
                ]
            },
            {
                tit: 'Data Visualization, Charts, D3.js',
                k: 'rebrand/FreeCodeCamp/Certification/DataVisualizationProjects',
                projs: [
                    {k:'bar-chart-using-d3-js/dist',n:'Bar Chart',tags:'JSE6,D3.js',d:''},
                    {k:'choropleth-map/dist',n:'Choropleth Map',tags:'JSE6,D3.js,topojson.js',d:''},
                    {k:'d3',n:'Point Chart',tags:'JSE6,D3.js',d:''},
                    {k:'heat-map/dist',n:'Heat Map Chart',tags:'JSE6,D3.js',d:''},
                    {k:'scatterplot-graph/dist',n:'Scatterplot Graph',tags:'JSE6,D3.js',d:''},
                    {k:'treemap-diagram/dist',n:'Tree Map Diagram',tags:'JSE6,D3.js,API,JSON,webservice',d:''},
                ]
            },
            {
                tit: 'Relation Database, Bash, PostgreSQL, PSQL',
                k: 'rebrand/FreeCodeCamp/Certification/RelationDatabase',
                projs: [
                    {k:'bike_rental/BikeRental.sh',n:'Bike Rental',tags:'Bash',d:''},
                    {k:'five_programs/bingo.sh',n:'Bingo',tags:'Bash',d:''},
                    {k:'five_programs/countdown.sh',n:'Countdown',tags:'Bash',d:''},
                    {k:'five_programs/five.sh',n:'Five',tags:'Bash',d:''},
                    {k:'five_programs/fortune.sh',n:'Fortune',tags:'Bash',d:''},
                    {k:'five_programs/questionnaire.sh',n:'Questionnaire',tags:'Bash',d:''},
                    {k:'kitty_ipsum_translator/translate.sh',n:'Kitty Ipsum Translator',tags:'Bash',d:''},
                    {k:'number_guess.',n:'Number guess',tags:'Bash,PSQL',d:''},
                    {k:'periodic_table.',n:'Periodic Table',tags:'Bash,PSQL',d:''},
                    {k:'salon.',n:'Salon',tags:'Bash,PSQL',d:''},
                    {k:'students/students_info.sh',n:'Students',tags:'Bash,PSQL',d:''},
                    {k:'worldcup.',n:'Worldcup',tags:'Bash,PSQL',d:''},
                    
                ]
            },
            {
                tit: 'Backend, npm, Node.js, Express.js, Mongoose.js, AZURE',
                k: 'rebrand/FreeCodeCamp/Certification/BackEndDevelopment',
                projs: [
                    {u:'https://lab-project-01.azurewebsites.net/api/exercisetracker',n:'Exercise Tracker',tags:'Node.js,Express.js,Mongoose.js,MONGODB,AZURE',d:''},
                    {u:'https://lab-project-01.azurewebsites.net/api/express',n:'Express Microservice',tags:'Node.js,Express.js,AZURE',d:''},
                    {u:'https://lab-project-01.azurewebsites.net/api/filemetadata.',n:'File Metadata',tags:'Node.js,Express.js,multer.js,AZURE',d:''},
                    {u:'https://lab-project-01.azurewebsites.net/api/headerparser.',n:'Header Parser',tags:'Node.js,Express.js,AZURE',d:''},
                    {u:'https://lab-project-01.azurewebsites.net/api/timestamp',k:'',n:'Time Stamp',tags:'Node.js,Express.js,AZURE',d:''},
                    {u:'https://lab-project-01.azurewebsites.net/api/urlshortener.',n:'URL Shortener',tags:'Node.js,Express.js,AZURE',d:''},
                ]
            }
        ] 
    };

    const data = {
        skills: [
            'C#, <strong>.NET 8</strong>, .NET Framework, Entity Framework',
            'MS SQL Server &amp; T-SQL, PostgreSQL &amp; PL/pgSQL',
            'MongoDB/Azure & EF Core, DynamoDB/AWS & Object Model',
			'<a href="https://redis.io/">Redis Database, in-memory storage cache</a>',
			'.NET CLI, AWS.CLI',
			'Docker Container, AWS EKS, AWS Lambda Serverless Function, AWS S3 Bucket, AWS Event Bridge',
			'<strong>VS Code using Dev Container running Docker in Ubuntu/Linux Virtual Machine</strong>',
			'ASP.NET Core using minimal API, ASP.NET MVC and Controller-based API',
            'JavaScript ES6, jQuery, Node.js, Express, React, Mongoose',
            'Tradingview Lightweight Charts js library, D3.js, HTML Canvas API',
            'HTML5, CSS, SCSS, Sass, Jekyll',
            'AWS, Azure',
            'Azure Key Vault, AWS Secret Keys',
			'AWS CodePipeline, Azure Bicep, Jenkins, GitHub Actions, NUnit',
            'Git, GitHub, VisualSVN Subversion, TortoiseSVN',
			'Domain Name System Start of Authority (<b>DNS SOA</b>) maintenance on <b>IBM cloud</b>',
			'Virtual Private Network (<b>VPN</b>) configuration using <a href="https://openvpn.net/">OpenVPN</a>',
			'Web application vulnerabilities test <a href="https://www.zaproxy.org/">OWASP ZAP</a>',
            'Project Management using Kanban ✔️, SCRUM, Waterfall, <a href="https://www.wrike.com">Wrike</a>✔️',
            '<a href="https://workspace.google.com">Google Workspace</a>, <a href="https://www.microsoft.com/en-us/microsoft-teams/group-chat-software/">Microsoft Teams</a>',
            'Visual Studio, VSCode, Notepad++ ✔️',
			'REST API Documentation using <i><a href="https://swagger.io/tools/swagger-ui/">SWAGGER UI</a>, <a href="https://www.postman.com/">Postman</a></i>',
			'System Integration using <i>RESTful API, TCP, HTTP, FTP, Stream, WebHook, WebSocket</i>',
			'Eletronic Trading System (ETS) Integration to <i>TD Ameritrade, Brazilian Stock Exchange, XP Broker, BTG, Genial, Terra, Cedro, Nelogica, Financial Information eXchange protocol (FIX)</i>',
			'Payment Integration to <i>Authorize.NET by Visa, Fiserv-First Data, Bradesco, Banco do Brasil, Itau, Brazilian Banks using (CNAB), PagSeguro, MercadoPago, PayPal, Payment Card Industry Data Security Standard (PCI DSS Compliance)</i>',
			'Logistics company Integration to <i>DHL, USPS, Correios</i>'
        ],
        softskills: ' T-shaped person,Friendliness,Active Listening,Collaboration,Adaptability,Research,Problem Solving,Self-taught Mindset'.split(','),
        certifications: [
            ['Back End Development and APIs @ FreeCodeCamp - January 31, 2024','https://www.freecodecamp.org/certification/sabsfilho/back-end-development-and-apis','Build microservices with npm, Node.js, Express.js, Mongoose.js and Mongo Database.'],
            ['Relation Database Certification @ FreeCodeCamp - January 29, 2024','https://www.freecodecamp.org/certification/sabsfilho/relational-database-v8','Create, query a relational database using PostgreSQL, PSQL, VS Code and Linux Bash commands. Build scripts for version control system commands using Git.'],
            ['Data Visualization Certification @ FreeCodeCamp - January 17, 2024','https://www.freecodecamp.org/certification/sabsfilho/data-visualization','Build charts, graphs, maps with JavaScript, D3.js, Babel, JSON API, AJAX'],
            ['Front End Development Libraries @ FreeCodeCamp - January 13, 2024','https://www.freecodecamp.org/certification/sabsfilho/front-end-development-libraries','Build Single Page Applications (SPAs) with HTML, Bootstrap, Sass, SCSS, JavaScript, React, Redux, Babel.'],
            ['Javascript Algorithms and Data Structures @ FreeCodeCamp - January 5, 2024','https://www.freecodecamp.org/certification/sabsfilho/javascript-algorithms-and-data-structures-v8','Build interactive interface using JavaScript fundamentals, Object Oriented and Functional Programming, Algorithms, Local storage, API Fetch data.'],
            ['Responsive Web Design @ FreeCodeCamp - December 28, 2023','https://www.freecodecamp.org/certification/sabsfilho/responsive-web-design','Build web pages with HTML5, CSS, SCSS, Flexbox and CSS Grid.'],
            ['Foundational C# with Microsoft @ FreeCodeCamp - December 11, 2023','https://www.freecodecamp.org/certification/sabsfilho/foundational-c-sharp-with-microsoft','Build C# applications using core concepts and object-oriented programming principles.'],
        ],
        profiles: [
            ['FreeCodeCamp','https://www.freecodecamp.org/sabsfilho','My learning place to assimilate new cool techies stuff and practice a lot in real case scenarios'],
            ['Git Hub','http://github.com/sabsfilho','My codespace.'],
            ['Microsoft','https://learn.microsoft.com/en-us/users/samuelsantos-1448/','My windows since my first deployment.'],
            ['HackerRank','https://www.hackerrank.com/profile/sabsfilho','My gym where I keep myself in good shape for hack activities.'],
            ['CodeWars', 'https://www.codewars.com/users/sabsfilho', 'My another gym...'],
            ['CodeWars', 'https://leetcode.com/u/sabsfilho/', 'and one more gym...'],
            ['CodePen','https://codepen.io/sabsfilho','My front end sandbox.'],
            ['Replit','https://replit.com/@sabsfilho','My back end sandbox.']
        ],
        education: [
            ['Computer Science &amp; System Project Management @ Pontifical Catholic University of Rio de Janeiro - PUC','https://www.puc-rio.br','2005-2006, Rio de Janeiro, RJ - Brazil'],
            ['Mechanical Engineering @ Federal University of Rio de Janeiro - UFRJ','http://www.mecanica.ufrj.br/ufrj-em/','1995-2001, Rio de Janeiro, RJ - Brazil']
        ],
        awards: [
            ['ABCM-EMBRAER 2004 prize in undergraduate category','https://abcm.org.br/symposium-series/SSM_Vol2/Section_II_Industrial_Instrumentation/SSM2_II_05.pdf',`
2001-2003, UFRJ Robotics Lab (LabRob), Rio de Janeiro, RJ - Brazil<br>
A Digital System for Measurements in Gypsum Molds for Orthodontics Mechanical Engineering Department
<a class="toggle-link" data-hidden="click here to see more info" data-shown="show less"></a>
<div class="toggle-panel">
<p>I was very lucky to be in the right place at the right time when I was invited to collaborate on this project.</p>
<p>At that time I was working as a C++ programmer at the Robotics Lab of the Federal University of Rio de Janeiro, UFRJ on a public funded research project.
This Lab coordinator asked me if I could offer some kind of help for his research team to solve a puzzle they were facing on another project which was a cooperation with the Orthodontics department from the Federal University of Mato Grosso do Sul, UFMS.<br>
A PHD doctor was doing research to propose a new technique to correct maxillae malformation, executing on the patient's jaws a series of surgeries based on the results from his study. In order to support him, we conceived a system to automate processes such as data acquisition, data manipulation, image visualization and evaluation of results from data analysis.</p>
I developed a dedicated Windows program coded in Borland C++ 6.0 which was responsible for capturing the joint variables acquisition and conversion into Cartesian coordinates, through direct kinematics relations. 
Then, the image of the mold contour was shown in the computer screen so that the user can visualize the results of the data acquisition being analyzed and decide whether they are ready or not to be registered in the database file. Statistics was extensively used to evaluate data from acquired curves. 
In 2003 this digital system for measuring gypsum molds was used by Dr. Marcelo Arruda and he evaluated more than 3000 models in three days at Dr. Andrew J. Haas Laboratory, in Chicago, USA.
The on site and offline tasks were performed with success.</p>
<p>The goodwill of this project was noteworthy and with the positive impact in so many patients' lives, we were awarded and recognized by the Mechanical Science and Engineering Brazilian Association (ABCM).</p>
<div class="digital-devices-imgs">
<img src="assets/img/digital-system/digital-device.jpg" alt="digital device" />
<div>Digital Device</div>
<img src="assets/img/digital-system/procedures.jpg" alt="diagram flow" />
<div>Diagram Flow</div>
<img src="assets/img/digital-system/interface.jpg" alt="software interface" />
<div>Software Interface</div>
</div>
</div>
`]

        ],
        outerITWorld: [
            `Capital Markets &amp; Securities Analyst For Trading Floor Certification<br>
1998-1999,  Rio de Janeiro Stock Exchange,  Rio de Janeiro, RJ - Brazil<br>
<em>Economics for Capital Markets; Financial and Statistical Calculation; Asset Classes; Financial Instruments and Markets; Equity Markets Trend Analysis; Portfolio Management; Brazilian Securities Law; Structure and Dynamics of a Trading Floor Negotiation</em>
<p class="first-p">The key aspect I learned from this course was risk control for portfolio management. This kind of mindset I apply on my projects, 
for instance managing the tradeoff to deploy a patch on production, we should take care of the risks involved from a breaking version, 
stepping in and out as handling a bad asset position to secure the fund health as a whole. I also learned that Risk Management means what to do before and when things go bad and this concept should be applied in too many aspects in our lives.</p>
`,
`Financial Mathematics with HP 12c<br>
1997, 40 hours, Rio de Janeiro Stock Exchange,  Rio de Janeiro, RJ - Brazil<br>
<em>Financial Fundamentals, Simple interest, Compound interest and Amortization, Discounted Cash Flow Analysis, Bond and Depreciation Calculations.</em>
<p class="first-p">I learned the financial power of compound interest which is the most important math equation we should learn.</p>
<p><em><q>There is no force in the universe more powerful than compound interest</q>, Albert Einstein</em></p>
`
        ]/*,
        entrepreneurship: [
            'entrepreneurship Adventures = teleprompter, casar É fácil, bomdeclick, homenzinho'
        ]*/
    };

    /* html templates */
    const templ = {
        accord: (i,n,w) => {
            const multiline = n.includes('<br') ? ' multiline' : '';
            return `<button class="accord-btn accord-l${i}${multiline}"><div data-hidden="+" data-shown="-"></div>${n}</button><div class="accord-panel">${w}</div>`
        },
        href: (u,t) => `<a href="${u}" rel="nofollow" target="_blank">${t}</a>`,
        item: (x) => {
            const zs = [templ.href(x[1],x[0])];
            if (x.length > 2){
                zs.push(`<div class="item-descr">${x[2]}</div>`)
            }
            return zs.join('')
        }
    },
    setText = (id, v) => document.getElementById(id).innerHTML = v,
    isArray = x => x.constructor === Array,
    addAccordeonEvent = (className)=>{

        const toggle = (el, hidden) => {
            if (el === null) return;
            if (el.hasAttribute('data-hidden')){
                el.innerHTML = hidden ? el.getAttribute('data-hidden') : el.getAttribute('data-shown')
                
            }
            else {
                toggle(el.firstChild, hidden)
            }
        };

        const els = document.getElementsByClassName(className);
        for(const el of els){
            toggle(el, true);
            el.addEventListener('click', function(){
                const hidden = this.nextElementSibling.style.display === 'block';
                this.classList.toggle("active");                
                this.nextElementSibling.style.display = hidden ? 'none' : 'block'
                toggle(el, hidden);
                const w = window.innerWidth;
                let eln = el;
                while(eln !== null && eln.tagName.toLowerCase() !== 'article'){
                    eln = eln.parentElement;
                }
                const p = eln.classList;

                if (!hidden && w > 990) {
                    p.add('expand')
                }
                else {
                    if (p.contains('expand')){
                        const chs = el.parentElement.children;
                        let hasExpanded = false;
                        for(const ch of chs) {
                            if (
                                ch.tagName.toLowerCase() == 'button' &&
                                ch.classList.contains('active')
                            ){
                                hasExpanded = true;
                                break
                            }
                        }
                        if (!hasExpanded){
                        p.remove('expand')
                        }
                    }
                }
            })
        }
        
    }
    buildItem = x=>isArray(x) ? templ.item(x) : x,
    buildList = ls => ['<ul>', ls.map(x=>`<li>${buildItem(x)}</li>`).join(''), '</ul>'].join(''),
    buildGroup = (descr, content) => {

        const buildAccord = (i, ws, z, ks)=>{
            if (!z) return;

            const zs = [];

            const addK = (k,l) => {
                let v = z[k];
                if (v) {
                    if (l) v = [l,v.split(',').join(', ')].join('');
                    zs.push(`<div class="accord-${k}">${v}</div>`)
                }
            },
            fnzk = ()=>{
                const qs = [ks.join(',')];
                let zk = z.k;
                if (zk[zk.length-1]==='.'){
                    zk = zk.substring(0,zk.length-1)
                }
                qs.push(zk);
                if (z.k.indexOf('.')===-1){
                    qs.push('index.html')
                }
                return qs.join('/')
            },
            u = 
            z.u ? z.u : 
            z.k ? fnzk() :
            null;
            if (u && z.n) {
                zs.push(templ.href(u,z.n))
            }
            else {
                addK('n');
            }
            
            addK('d');
            addK('tags','skills: ');

            if (z.k){
                ks.push(z.k)
            }

            if (z.projs) {                
                z.projs.forEach(p => buildAccord(i+1, zs, p, [...ks]));
            }
            else if (z.bdy) {
                zs.push(`<div class="ext-bdy" data-bdy="${z.bdy}">carregando...</div>`)                
            }
            
            ws.push(
                z.tit ? 
                templ.accord(i, z.tit, zs.join('')) :
                zs.join('')
            )
        };

        const qs = [`<p>${descr}</p>`];

        buildAccord(0, qs, content, []);

        return qs.join('')
    },
    buildShowcases = () => buildGroup('Click on the buttons below to see some of my skills in action.', showCase),
    buildExperiences = () => buildGroup('Click on the buttons below to see my work experience.', experience),
    getFirstByClass = (el, cn) => el.getElementsByClassName(cn)[0],
    getFirstByTag = (el, cn) => el.getElementsByTagName(cn)[0],
    loadExternalBody = () => {
        const els = document.getElementsByClassName('ext-bdy');
        for(const el of els) {
            fetch(`assets/html/portfolio/${el.getAttribute('data-bdy')}.html`)
            .then(x => x.text())
            .then(x => el.innerHTML = x)        
            .catch(error => {
                return Promise.reject(error);
            })
        }

    },
    addBlocks = ()=>{
        const panel = document.getElementById('panel');
		
		const vids = `<div class="vid">
<div>
<embed src="https://docs.google.com/file/d/1OY46AiLuqPmG4PJScHkDyuAQZ7xETApT/preview">
<div>Short Introduction</div>
</div>
<div>
<embed src="https://docs.google.com/file/d/1MZBidAZR2YWW03qooKx6P0SD5ZKGfTT7/preview">
<div>About Me Presentation</div>
</div>
</div>`;
/*
mainContent = {
    body,
    href,
    index,
    tagImg,
    tagColor,
    tit
}
*/
        const mainContents = [
            {
                body:`
<div class="bio">
<p>I am a seasoned System Engineer and Full Stack Developer specializing in the Microsoft stack with more than 25 years in software development and team management, helping people in Banking, Startup and Fintech companies.${vids}</p>
<p class="currentmemo">&ldquo;Currently I am working on a brownfield project, being responsible to modernize our .NET Framework ecosystem from a monolithic architecture based in Virtual Machines running Windows Servers to a Service Oriented Architecture, using AWS Lambda Serverless Function, DynamoDB, AWS RDS for SQL Server, AWS S3 Bucket, AWS Event Bridge, .NET 8, Entity Framework, Docker images and applying the .NET Microservices Architecture.<img class="AWSLambdaFunction" src="assets/img/AWSLambdaFunction.jpg"> I am coding on a VS Code Dev Container running a Docker in Docker approach on a Ubuntu/Linux EC2 Instance and using GitHub for version control. Before getting this project approval, I developed a .NET Core Web App consuming  resources of my personal Azure account in order to build a prototype and create a viability study for this modernization. I've crafted an <a target="_blank" href="https://docs.google.com/document/d/1Yg7iscwM2IChCxy66aYhOB4-kA_9cgu6XC3Ar5RNn5k/edit?usp=sharing">all-in-one guide (click to open)</a> to help me train my colleagues to publish .NET 8 microservices to AWS Lambda Function, using really cool stuff and also reducing our costs !&rdquo;</p>
<p>I graduated in Mechanical Engineering from Federal University of Rio de Janeiro - UFRJ, one of the most prestigious universities in Brazil, and worked in their Robotics Lab until graduation. I post-graduated in Computer Science & System Project Management from Pontifical Catholic University of Rio de Janeiro - PUC-RIO also a renowned university in Brazil.</p>
<p>I am a researcher by nature and I am very proud to say that one of my research projects was awarded and recognized with the ABCM-EMBRAER 2004 prize.</p>
<p>My CEO usually says that I am a T-shaped person collaborating and nurturing multiple areas of connections. As I am a developer with a mechanical engineering, academic research and financial background, I can easily cross beyond borders building strong bridges with network, security, compliance, sales and business teams.</p>
<p>For the last 10 years I have been working asynchronously as a Full Stack Developer specializing in JavaScript and C# .NET.  in a full remote position in a Fintech company that develops stock market trading solutions, including a stock portfolio management system that autonomously makes smart and fast trade decisions, using Quant trading strategies.</p>
<a class="toggle-link" data-hidden="click here to see more info" data-shown="show less"></a>
<div class="toggle-panel">
<p>Impacting real demanding users who are wealthy and high-profile banking customers, this Fintech project is a dream come true for people that love software engineering and problem-solving routine because of its technical challenges we face everyday. It is a real world sandbox in production, where I do a lot of research, learn and experiment new techie acknowledgments in countless use case scenarios, that can be applied beyond borders in many IT projects of companies around the world. So, I am sure I can bring value and a humble collaboration to my future partners, sharing thoughts and having an active listening approach to my colleagues opinions, growing a deeper connection based in empathy, respect and friendliness.</p>
<p>All the business logic implementations I try to apply some design patterns concepts detailed in the Gang of Four book, also I like to get inspired by some SOLID ideas and Domain-Driven Design to help non-coders to understand what I've meant to deliver. Before coding, I collect all kinds of requirements or specifications to clearly describe and tell a good user story, a task or use case scenario. This procedure helps me continue improving the concept and also deliver small pieces to a business partner follows its evaluation.</p>
<p>Besides the business logic in the backend side written in C#, for the frontend I also created an extensive JavaScript framework library to help build dynamic and responsive web interfaces, including dialog windows, forms, dynamic and smart spreadsheets, reports, interactive charts, and client-server communication consuming our REST API services.</p>
<p>Nowadays I am migrating some old modules that use legacy .NET web services to a modern microservice concept using Node.js and React.js. I recently got some  proficiency certifications in the MERN stack that helped me get the support I needed to start this transition.</p>
<p>Recently, I started a personal project to use some Deep Learning techniques using the ML.NET Framework with the purpose of getting better results in our prediction models. For this project I started to use some libraries and models using Python, Pandas, Jupyter, Seaborn, Scikit-learn, Keras and TensorFlow coding in VSCode and Google Colab.</p>
<p>I'm currently looking for the opportunity to work remotely in IT projects abroad.</p>
<p>My hour is a commodity that your budget can take advantage of.
As I work from the seashore of the wonderful City of Rio de Janeiro, Brazil, we can together be very happy with the currency exchange rates. So, it's definitely a win–win game for us!</p>
<p>Available to start work right now on a full or part-time remote job,
<br/><u>also flexible for any time zone overlap</u>.</p>
<p><em>I need employer sponsorship to work within the United States.</em></p>
<div>
<span>Please send me a message if you want to talk about how we can team up:</span>
<textarea id="msg" class="msg" maxlength="500"></textarea>
<div class="email-blk">
<span class="mailme">remember to <strong>include your e-mail</strong> to allow me reply you an soon as possible.</span>
<div>
<label for="email">e-mail:</label>
<input id="email" type="email" placeholder="type your e-mail here" />
</div>
</div>
<button id="sendbtn">Send</button>
</div>
</div>
</div>
                `,
                index:0,
                tagImg:'assets/img/sailboat02.jpg',
                tit:'About'
            },
            {
                body:`${buildList(data.skills)}
<p><em>DORMANT Skills<sub> used to work with a long time ago</sub></em><br>
<em>- JAVA, C++, C</em></p>
<p><em>FORTHCOMING Skills<sub>learning and improving</sub></em><br>
<em>- Deep Learning techniques</em><br>
<em>- ML.NET</em><br>
<em>- Python, Pandas, Jupyter, Seaborn, Scikit-learn, Keras and TensorFlow</em><br>
<em>- Google Colab &amp; VSCode</em></p>            
                `,
                index: 1,         
                tagImg: 'assets/img/wave.jpg',
                tit: 'Skills'
            },
            {
                body: buildList(data.softskills),
                index: 2,
                tagImg: 'assets/img/softskills.jpg',
                tit: 'Core Skills'
            },
            {
                body: buildShowcases(),
                index: 3,
                tagImg: 'assets/img/library.jpg',
                tit: 'Showcases'
            },
            {
                body: buildList(data.certifications),
                index: 4,
                tagImg: 'assets/img/lego-bricks.jpg',
                tit: 'Certifications'
            },
            {
                body: buildExperiences(),
                index: 5,
                tagImg: 'assets/img/trophies4.jpg',
                tit: 'Work Experience'
            },
            {
                body: buildList(data.profiles),
                index: 8,
                tagImg: 'assets/img/stamps.jpg',
                tit: 'Profiles'
            },
            {
                body: buildList(data.education),
                index: 6,
                tagImg: 'assets/img/education.jpg',
                tit: 'Education'
            },
            {
                body: buildList(data.awards),
                index: 7,
                tagImg: 'assets/img/medals.jpg',
                tit: 'Awards'
            },
            {
                body: buildList(data.outerITWorld),
                index: 9,
                tagImg: 'assets/img/milky-way.jpg',
                tit: 'Outer IT World Courses'
            }
        ].sort((a,b)=>b.index-a.index);

        const getHref = c => c.href ? c.href : '#';

        const addBlock = (c)=>{
            const href = getHref(c),
            h = `
<a class="post-thumbnail" style="background-image: url(${c.tagImg})" href="${href}/"></a>          
<div class="post-content">
<h2 class="post-title"><a href="${href}">${c.tit}</a></h2>
${c.body}
</div>
        `,
            elem = document.createElement('article');
            elem.className = 'post';
            elem.innerHTML = h;
            panel.prepend(elem)

        };

        for(const c of mainContents){
            addBlock(c)
        }

        addAccordeonEvent('accord-btn');
        addAccordeonEvent('toggle-link');

    };

    const addDialog = (tit,msg,pnt,btnID)=>{
        const div = document.createElement('div');
        div.className = 'dlg-pin';
        div.innerHTML = `
<div class="dlg">
<div class="tit">
        <div class="leg">${tit}</div>
        <div class="btn-x close">X</div>
</div>
<div class="bdy">${msg}</div>
</div>
        `;
        if (pnt){
            pnt.append(div);
        }
        else{
            document.getElementsByTagName('body')[0].append(div)
        }

        const toggle = () => {
            div.style.visibility = div.style.visibility==='visible' ?  'hidden' : 'visible'
        };
        
        getFirstByClass(div, 'close').addEventListener('click', ()=>div.style.visibility='hidden');
        if (btnID){
            document.getElementById(btnID).addEventListener('click', toggle);
        }

        return div
    };

    const addMailDialog = ()=>{
        const m = '115,97,109,117,101,108,46,115,97,110,116,111,115,46,101,110,103,105,110,101,101,114,64,103,109,97,105,108,46,99,111,109'.split(',').map(x=>String.fromCharCode(x)).join('');
        const pnt = getFirstByClass(document, 'contact'),
        dlg = addDialog(
            'This is my contact e-mail',
            `
<a href="mailto:${m}">${m}</a>
<a class="copy close mailto" href="#"><span class="tooltipcopy">e-mail copied</span>click to copy</a>
            `,
            pnt, 
            'mailto'
        );
        getFirstByClass(dlg, 'dlg').classList.add('dlgmail');
        getFirstByClass(dlg, 'copy').addEventListener('click', function(){
            const sty = getFirstByClass(dlg, 'tooltipcopy').style;
            navigator.clipboard.writeText(m);
            sty.visibility = 'visible';
            setTimeout(()=>sty.visibility = 'hidden', 2000)
        });
        getFirstByTag(document, 'body').addEventListener('click', function(e){
            const cn = e.srcElement.className;
            if (
                dlg.style.visibility==='visible' &&
                !cn.includes('mailto') &&
                !cn.includes('bdy') &&
                !cn.includes('leg')
            ){
                getFirstByClass(dlg, 'close').click()
            }
        });

    };

    const addMessageControl = ()=>{
        const alertDlg = addDialog();
        alertDlg.style.position = 'absolute';
        document.getElementById('sendbtn').addEventListener('click', function(e){
            const showMsg = (leg,m) => {
                getFirstByClass(alertDlg, 'leg').innerHTML = leg;
                getFirstByClass(alertDlg, 'bdy').innerHTML = m;
                alertDlg.style.visibility = 'visible';
                const r = msg.getBoundingClientRect();
                alertDlg.style.top = (r.top+window.scrollY)+'px';
                alertDlg.style.left = (r.right-400)+'px';
            };
            const isValidEmail = () => {
                return String(email.value)
                  .toLowerCase()
                  .match(
                    /^(([^<>()[\]\\.,;:\s@"]+(\.[^<>()[\]\\.,;:\s@"]+)*)|.(".+"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/
                  );
              };
            
            const msg = document.getElementById('msg'),
            email = document.getElementById('email');

            if (!msg.value){
                showMsg('Alert','Please type a short message about your project.');
                msg.focus();
                return
            }
            if (!isValidEmail()){
                showMsg('Alert','Please type a valid e-mail to allow me reply you.');
                email.focus();
                return
            }

            const fd = new FormData();
            fd.append('email', email.value);
            fd.append('msg', msg.value);

            fetch('https://lab-project-01.azurewebsites.net/api/contact/skills', {
                method: "POST",
                body: fd
            })
            .then(result => {
                showMsg('Success', `<div class="success-msg">I got your message!<br><br>I'll reply to you soon.<br><br>Thank you so much!<br></div>`);
                msg.value = '';
                email.value = '';
                setTimeout(()=>{
                    alertDlg.style.visibility = 'hidden'
                },5000)
            })            
            .catch(error => {
                showMsg('Error', error);
                return Promise.reject(error);
            });
        })
    };

    const load = ()=>{

        addBlocks();

        setText('year', new Date().getFullYear());

        addMailDialog();
        
        addMessageControl();

        loadExternalBody();
    };

    return {
        load: load
    }
}();

window.addEventListener('load', CtMain.load)