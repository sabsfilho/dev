const CtMain = function(){

    const showCase = {
        projs: [
            {
                tit: 'Jobs',
                projs: [
                    {p:'',u:'http://h2.putcallbot.com/',k:'',n:'Put.Call.Bot Quant Trade System Platform',tags:'C#,.NET,T-SQL,HTML5,CSS,Javascript,jQuery',d:`Put.Call.Bot is a software solution that evaluates quantitative analysis from real time
                    Bovespa exchange market data, sending buy and sell signals to broker according to the
                    algorithmic strategy chosen by the trader.`},
                ]
            },
            {
                tit: 'Web Design & Style',
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
                    {k:'PortfolioDemo',n:'Portfolio Demo',tags:'HTML5,CSS,SCSS,Flexbox,CSS Grid',d:''},
                    {k:'RegistrationForm',n:'Registration Form',tags:'HTML5,CSS,SCSS,Flexbox,CSS Grid',d:''},
                    {k:'RothkoPainting',n:'Rothko Painting',tags:'HTML5,CSS,SCSS,Flexbox,CSS Grid',d:''},
                    {k:'SurveyForm',n:'SurveyForm',tags:'HTML5,CSS,SCSS,Flexbox,CSS Grid',d:''},
                    {k:'TechnicalDocumentation',n:'Technical Documentation',tags:'HTML5,CSS,SCSS,Flexbox,CSS Grid',d:''},
                    {k:'TributePage',n:'Tribute Page',tags:'HTML5,CSS,SCSS,Flexbox,CSS Grid',d:''}
                ]
            }
        ] 
    };

    const data = {
        skills: [
            'C#, .NET',
            'MS SQL Server &amp; T-SQL, PostGRE &amp; PL/pgSQL, MongoDB',
            'JavaScript ES6, jQuery, Node.js, Express, React, Mongoose, RESTful',
            'HTML5, CSS, SCSS, Sass, Jekyll',
            'AWS, Azure',
            'Project Management (Kanban ✔️, SCRUM, Waterfall)',
            'Git, GitHub, Apache Subversion, TortoiseSVN'
        ],
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
            ['FreeCodeCamp','https://www.freecodecamp.org/sabsfilho','An amazing place where I learn new cool techies stuff and practice a lot, building real case solutions.'],
            ['Microsoft','https://learn.microsoft.com/en-us/users/samuelsantos-1448/','My windows since I was deployed.'],
            ['HackerRank','https://www.hackerrank.com/profile/sabsfilho','My gym where I keep myself in good shape for hack activities.'],
            ['CodePen','https://codepen.io/sabsfilho','My front end sandbox.'],
            ['Replit','https://replit.com/@sabsfilho','My back end sandbox.'],
            ['CodeAlly','https://codeally.io/cv/1925e7e676abb9663fe62f5e','My job sandbox.']
        ],
        education: [
            ['Computer Science &amp; System Project Management @ Pontifícia Universidade Católica - PUC','https://www.puc-rio.br','2005-2006, Rio de Janeiro, RJ - Brazil'],
            ['Mechanical Engineer @ Federal University of Rio de Janeiro - UFRJ','http://www.mecanica.ufrj.br/ufrj-em/','1995-2001, Rio de Janeiro, RJ - Brazil']
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
stepping in and out as handling a bad asset position to secure the fund health as a whole.</p>
`,
`Financial Mathematics with HP 12c<br>
1997, 40 hours, Rio de Janeiro Stock Exchange,  Rio de Janeiro, RJ - Brazil<br>
<em>Financial Fundamentals, Simple interest, Compound interest and Amortization, Discounted Cash Flow Analysis, Bond and Depreciation Calculations.</em>
<p class="first-p">I learned the financial power of compound interest which is the most important math equation we should learn.</p>
<p><em><q>There is no force in the universe more powerful than compound interest</q>, Albert Einstein</em></p>
`
        ]
    };

    /* html templates */
    const templ = {
        accord: (i,n,w) => {
            return `<button class="accord-btn accord-l${i}"><div data-hidden="+" data-shown="-"></div>${n}</button><div class="accord-panel">${w}</div>`
        },
        href: (u,t) => `<a href="${u}" rel="nofollow">${t}</a>`,
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
            })
        }
        
    }
    buildItem = x=>isArray(x) ? templ.item(x) : x,
    buildList = ls => ['<ul>', ls.map(x=>`<li>${buildItem(x)}</li>`).join(''), '</ul>'].join(''),
    buildShowcases = () => {

        const buildAccord = (i, ws, z)=>{
            if (!z) return;

            const zs = [];

            const addK = (k,l) => {
                let v = z[k];
                if (v) {
                    if (l) v = [l,v].join('');
                    zs.push(`<div class="accord-${k}">${v}</div>`)
                }
            },
            u = 
            z.u ? z.u : 
            z.k ? ['rebrand/FreeCodeCamp/Certification/ResponsiveWebDesign',z.k,'index.html'].join('/') :
            null;

            if (u) {
                zs.push(templ.href(u,z.n))
            }
            else {
                addK('n');
            }
            
            addK('d');
            addK('tags','skills: ');

            if (z.projs) {                
                z.projs.forEach(p => buildAccord(i+1, zs, p));
            }
            
            ws.push(
                z.tit ? 
                templ.accord(i, z.tit, zs.join('')) :
                zs.join('')
            )
        };

        const qs = ['<p>Click on the buttons below to see some of my skills in action.</p>'];

        buildAccord(0, qs, showCase);

        return qs.join('')
    },
    addBlocks = ()=>{
        const panel = document.getElementById('panel');
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
<p>I've been working in Rio de Janeiro, Brazil for more than 25 years in software development and team management in Brazilian IT, Banking and Fintech companies.</p>
<p>I graduated in Mechanical Engineering and post-graduated in Computer Science & System Project Management.</p>
<p>Over the last 10 years, I've been working asynchronously in a full remote position in a small Fintech company that develops stock market trade solutions, including a stock portfolio management system that autonomously makes smart and fast trade decisions, using Quant trading strategies.</p>
<p>I'm currently looking for the opportunity to work remotely in IT projects abroad.</p>
<p>My hour is a commodity that your budget can take advantage of.
As I work from Brazil, we can together be very happy with the currency exchange rates. So, it's definitely a win–win game for us!</p>
<p>Available to start work right now on a full or part-time remote job at 4PM-6AM GMT,
<br/><u>also flexible for any time zone overlap</u>.</p>
<p><em>I need employer sponsorship to work within the United States.</em></p>
<p>
<span>Please send me a message if you want to talk about how we can team up:</span>
<textarea class="msg" maxlength="500"></textarea>
<span class="mailme">remember to <strong>include your e-mail</strong> in this message to allow me reply you an soon as possible.</span>
<button class="sendbtn">Send</button>
</p>
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
                body: buildShowcases(),
                index: 2,
                tagImg: 'assets/img/library.jpg',
                tit: 'Showcases'
            },
            {
                body: buildList(data.certifications),
                index: 3,
                tagImg: 'assets/img/lego-bricks.jpg',
                tit: 'Certifications'
            },
            {
                body: buildList(data.profiles),
                index: 6,
                tagImg: 'assets/img/stamps.jpg',
                tit: 'Profiles'
            },
            {
                body: buildList(data.education),
                index: 4,
                tagImg: 'assets/img/education.jpg',
                tit: 'Education'
            },
            {
                body: buildList(data.awards),
                index: 5,
                tagImg: 'assets/img/medals.jpg',
                tit: 'Awards'
            },
            {
                body: buildList(data.outerITWorld),
                index: 7,
                tagImg: 'assets/img/milky-way.jpg',
                tit: 'Outer IT World'
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

    const load = ()=>{

        addBlocks();

        setText('year', new Date().getFullYear());
        
    };

    return {
        load: load
    }
}();

window.addEventListener('load', CtMain.load)