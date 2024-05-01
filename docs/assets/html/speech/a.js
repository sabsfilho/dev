const load = ()=>{
	/*var d = document.createElement('div');
	d.id = 'mask';
	d.style.top = '400px';
	document.getElementsByTagName('body')[0].appendChild(d);*/
	const div = document.getElementById('txt');
	div.innerHTML = div.innerHTML.replace(/\n/g,'<br>').replace(/\t/g,'&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;')
	div.style.display = 'block';
	window.scrollTo(0,0);
	const i = 1;
	const t = 10;
	const fn = () => {
		window.scrollBy(0, i);
		//d.style.top = (i+parseInt(d.style.top))+'px';
		setTimeout(fn, t);
	}
	setTimeout(fn, 10000);
};
window.onload = load