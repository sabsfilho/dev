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
            ['FreeCodeCamp','https://www.freecodecamp.org/sabsfilho'],
            ['Microsoft','https://learn.microsoft.com/en-us/users/samuelsantos-1448/'],
            ['HackerRank','https://www.hackerrank.com/profile/sabsfilho'],
            ['CodePen','https://codepen.io/sabsfilho'],
            ['Replit','https://replit.com/@sabsfilho'],
            ['CodeAlly','https://codeally.io/cv/1925e7e676abb9663fe62f5e']
        ],
        education: [
            ['Computer Science &amp; System Project Management @ Pontifícia Universidade Católica - PUC','https://www.puc-rio.br','2005-2006, Rio de Janeiro, RJ - Brazil'],
            ['Mechanical Engineer @ Federal University of Rio de Janeiro - UFRJ','https://ufrj.br','1995-2001, Rio de Janeiro, RJ - Brazil']
        ],
        outerITWorld: [
            `Capital Markets &amp; Securities Analyst  For Trading Floor Certification<br>
1998-1999,  Rio de Janeiro Stock Exchange,  Rio de Janeiro, RJ - Brazil<br>
<em>Economics for Capital Markets; Financial and Statistical Calculation; Asset Classes; Financial Instruments and Markets; Equity Markets Trend Analysis; Portfolio Management; Brazilian Securities Law; Structure and Dynamics of a Trading Floor Negotiation</em>`,
`Financial Mathematics with HP 12c<br>
1997, 40 hours, Rio de Janeiro Stock Exchange,  Rio de Janeiro, RJ - Brazil<br>
<em>Financial Fundamentals, Simple interest, Compound interest and Amortization, Discounted Cash Flow Analysis, Bond and Depreciation Calculations.</em>`
        ]
    };

    /* html templates */
    const templ = {
        accord: (i,n,w) => {
            return `<button class="accord accord-l${i}">${n}</button><div class="accord-panel">${w}</div>`
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
    buildItem = x=>isArray(x) ? templ.item(x) : x,
    buildList = ls => ['<ul>', ls.map(x=>`<li>${buildItem(x)}</li>`).join(''), '</ul>'].join(''),
    buildShowcases = () => {

        const buildAccord = (i, ws, z)=>{
            if (!z) return;

            const zs = [];

            const addK = k => {
                if (z[k]) {
                    zs.push(`<div class="accord-${k}">${z[k]}</div>`)
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
            addK('tags');

            if (z.projs) {                
                z.projs.forEach(p => buildAccord(i+1, zs, p));
            }

            
            ws.push(
                z.tit ? 
                templ.accord(i, z.tit, zs.join('')) :
                zs.join('')
            )
        };

        const qs = [];
        buildAccord(0, qs, showCase);

        const x = `${qs.join('')}
    Interface
    <ul>
    <li><a href="rebrand/FreeCodeCamp/Certification/ResponsiveWebDesign/CatPainting/index.html">CatPainting</a></li>
    <li>MS SQL Server &amp; T-SQL, PostGRE &amp; PL/pgSQL, MongoDB</li>
    </ul>
                    `;
        return x
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
<p>Available to start work right now on a full or part-time remote job at 4PM-6AM GMT,
<br/>also flexible for any time zone overlap.</p>
<p><em>I need employer sponsorship to work within the United States.</em></p>
<p>
<span>Please send me a message if you want to talk about how we can team up:</span>
<textarea class="msg" maxlength="500"></textarea>
<span class="mailme">remember to include your e-mail in this message to allow me reply you an soon as possible.</span>
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
                index: 5,
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
                body: `
<p dir="auto">ABCM-EMBRAER 2004 prize in undergraduate category.<br>
<em>A Digital System for Measurements in Gypsum Molds for Orthodontics Mechanical Engineering Department.</em></p>
                `,
                index: 6,
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