const CtMain = function(){

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
            ['CS &amp; System Project Management @ Pontifícia Universidade Católica - PUC','https://www.puc-rio.br','2005-2006, Rio de Janeiro, RJ - Brazil'],
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

    /*
        - Skills
        - Showcases
        - Certifications
        - Profiles
        - Education
        - Awards
        - Outer IT World

    */

    const templ = {
        item: (x) => {
            const zs = [`<a href="${x[1]}" rel="nofollow">${x[0]}</a>`];
            if (x.length > 2){
                zs.push(`<div class="item-descr">${x[2]}</div>`)
            }
            return zs.join('')
        }
    },
    isArray = x => x.constructor === Array,
    buildItem = x=>isArray(x) ? templ.item(x) : x,
    buildList = ls => ['<ul>', ls.map(x=>`<li>${buildItem(x)}</li>`).join(''), '</ul>'].join(''),
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
<span class="mailme">remember to include your e-mail in the message to allow me reply you an soon as possible.</span>
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
                body: `
Interface
<ul>
<li><a href="rebrand/FreeCodeCamp/Certification/ResponsiveWebDesign/CatPainting/index.html">CatPainting</a></li>
<li>MS SQL Server &amp; T-SQL, PostGRE &amp; PL/pgSQL, MongoDB</li>
</ul>
                `,
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
                index: 4,
                tagImg: 'assets/img/stamps.jpg',
                tit: 'Profiles'
            },
            {
                body: buildList(data.education),
                index: 5,
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

        addBlocks()
        
    };

    return {
        load: load
    }
}();

window.addEventListener('load', CtMain.load)