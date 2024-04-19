const CtCtl = function() {

    const addButton = (act, method, nm, o) => {
        var btn = document.createElement('button');
        btn.innerText = nm;
        btn.onclick = () => {
            fetch(act, {
                method: method,
                body: JSON.stringify(o),
                headers: {"Content-type": "application/json; charset=UTF-8"}
              })
              .then(response => response.json()) 
              .then(json => console.log(json))
              .catch(err => console.log(err))
        };
        document.getElementsByTagName('body')[0].appendChild(btn);

    }

    const load = ()=>{
        addButton('/Pizza', 'GET', 'GET Pizzas');
        addButton('/Pizza', 'POST', 'POST Pizza', {"name":"Calab","isGlutenFree":false});
        addButton('/Pizza/3', 'PUT', 'PUT Pizza', {"id":"3", "name":"Calabresa"});
        addButton('/Pizza/2', 'DELETE', 'DELETE Pizza', {});
    };

    return {
        load:load
    }
}();

window.onload = CtCtl.load;