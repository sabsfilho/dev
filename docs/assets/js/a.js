const CtCrack = function(){

    const bs = {
		B3:'starting...',
		B17:'Why are you leaving your current job?',
		B18:'What are you looking for in a new position?',
		B19:'How would your boss and coworkers describe you?',
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
	scs = {
		SC1: 'What technical skills or tools are you proficient in that are directly relevant to this role?',
		SC2: 'Can you provide examples of how you have applied your skills in previous projects or tasks?',
		SC3: 'Are there any specific certifications or training programs you have completed that enhance your abilities for this position?',
		SC4: 'How do you stay updated and continue to develop your skills in your field?',
		SC5: 'Tell me about a time you demonstrated leadership skills',
		SC6: 'Helper'
	},
	ps = {
		PS1: 'Can you provide an example of a complex problem you encountered at work and walk me through the steps you took to solve it?',
		PS2: 'What is the most creative idea or project youve generated in your current role?',
		PS3: 'Tell me about a time when you identified a process or workflow that needed improvement. What did you do about it?',
		PS4: 'Have you ever had a deadline you werent able to meet? What happened?',
		PS5: 'Describe a time when you had to make a decision based on limited information or under time pressure. How did you handle that?',
		PS0: 'Helper'
	},
	tcs = {
		TC1: 'Do you prefer teamwork or working independently?',
		TC2: 'Tell me about a time you worked well as part of a team.',
		TC3: 'How do you handle disagreements or conflicts within a team?',
		TC4: 'Have you collaborated with individuals from different departments?',
		TC5: 'Have you ever had difficulty working with a manager or other team members?',
		TC6: 'Helper'
	},
	cps = {
		CP1: 'Where do you see yourself professionally in the next few years?',
		CP2: 'Would you say that this position aligns with your professional goals?',
		CP3: 'Whats one thing you do every day that brings you closer to reaching your career goals?',
		CP4: 'What do you hope to accomplish within the next few years at this company?',
		CP5: 'How do you plan to stay motivated and committed to your career goals in the face of challenges or setbacks?',
		CP6: 'Helper'
	},
	sbs = {
		SB1: 'Can you provide an overview of your salary expectations for this role?',
		SB2: 'Are there any specific benefits or perks that you value and would like to see included in your compensation package?',
		SB3: 'Can you share any considerations or factors that influenced your salary expectations for this position?',
		SB4: 'What are your priorities when it comes to the overall compensation package, including salary, benefits, and potential growth opportunities?',
		SB5: 'Helper'
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
		S5: 'Open Web Application Security Project (OWASP)',
		S6: 'ISO/IEC 27001:2022'
	},
	ds = {
		D0: 'GoF Design Patterns',
		D1: 'functional requirements'
	},
	gs = {
		'Behavioral': bs,
		'Skills and Competencies': scs,
		'Problem-solving and Critical Thinking': ps,
		'Teamwork and Collaboration': tcs,
		'Career Planning': cps,
		'Salary and Benefits': sbs,
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