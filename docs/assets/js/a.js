const CtCrack = function(){

    const bs = {
		B3:'starting...',
		B4:'Tell me something about yourself MEDIUM',
		B0:'Tell me something about yourself LONG',
		B11:'How would you describe yourself? SHORT-SOFT SKILLS',
		B1:'Tell me about some of your strengths and weaknesses',
		B2:'What are your favorite software engineering books and why',
		B5:'What were your main responsibilities in your previous job?',
		B6:'When was the last time you were in a crunch? What could have prevented the situation and what changed to avoid it in the future?',
		B7:'Why should we hire you as a software engineer on our team?',
		B8:'How do you work independently and as part of a team? Which do you prefer?',
		B9:'Do you prefer startup company environments or in a more established atmosphere? Why?',
		B10:'Describe a time you overcame a non-technical obstacle at work.',
		B12:'In what areas are you talented?',
		B13:'What are examples of times you’ve used those talents?',
		B14:'How have your talents helped you succeed in different areas of your life?',
		B15:'What do you visualize for your career?',
		B16:'What would be your top priorities in your next role?'
	},
	cs = {
		C0: 'C# Interview Questions'
	},
	secs = {
		S0: 'What techniques would you use to prevent a brute-force login attack?',
		S1: 'What is cross-site scripting?',
		S2: 'What is a three-way handshake?',
		S3: 'What are some factors that can cause software vulnerabilities?',
		S4: 'How would you prevent hackers from conducting this kind of attack?',
		S5: 'Open Web Application Security Project (OWASP)'
	},
	ds = {
		D0: 'GoF Design Patterns',
		D1: 'functional requirements'
	},
	gs = {
		'Behavioral': bs,
		'C#': cs,
		'Security': secs,
		'Design': ds,
	},
	loadBlock = (ks)=>{
		const xs = ['<div>'];
		for(let k in ks){
			xs.push('<div>');
			xs.push(`<div class="btn tit2" data-k="${k}">${ks[k]}</div>`);
			xs.push('<div></div>');
			xs.push('</div>');
		}
		xs.push('</div>');
		return xs.join('')
	},
	parse = (x)=>{
		return x.replaceAll('\n','<br>')
	},
	load = ()=>{
		const div = document.getElementById('main'), xs = [];

		for(const g in gs){
			xs.push('<div>');
			xs.push(`<div class="btn tit1">${g}</div>`);
			xs.push(loadBlock(gs[g]));
			xs.push('</div>');
		}

		div.innerHTML = xs.join('');

		const btns = document.getElementsByClassName('btn');
		for(const x of btns){
			x.addEventListener('click', function(e){
				const z = e.target.getAttribute('data-k'),
				nxt = this.nextElementSibling,
				hidden = nxt.style.display === 'block';
				this.classList.toggle("active");                
                nxt.style.display = hidden ? 'none' : 'block';
				if (z && !nxt.innerHTML) {			
					nxt.innerHTML = 'loading...';
					fetch(`assets/html/crack/${z}.csv`)
					.then(x => x.text())
					.then(x => nxt.innerHTML = parse(x))        
					.catch(error => {
						return Promise.reject(error);
					})
				}
			})
		}
    };

    return {
        load: load
    }
}();

window.addEventListener('load', CtCrack.load)