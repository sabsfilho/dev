const CtCtl = function() {

    const setValue = item =>`<span class="fi fi-${item.code}"></span><span class="countryname">${item.value}</span>`;

    const loadCountryList = (cb)=>{
            fetch('/assets/flag-icons/country.json', {
                method: 'GET'
              })
              .then(response => response.json()) 
              .then(cb)
              .catch(err => console.log(err))
    };

    const countrySet = new Map();

    const addCountryPanel = (pnt, accord)=>{
        const item = pnt.data('item');
        if (countrySet.has(item.code)) return;
        countrySet.set(item.code);
        accord.append(`<h3>${setValue(item)}</h3>`);
        const bdy = $(`<div><div class="countrydescription"><div>Continent: ${item.continent}</div><div>Capital: ${item.capital}</div></div></div>`);
        accord.append(bdy);
        accord.accordion( "refresh");
        pnt.find('.countryinput').val('');
    };

    const addCountrySelection = (pnt)=>{
        const panel = $('<div class="countryselection"></div>'),
        accord = $('<div class="clubs"></div>').accordion({ collapsible: true, active: false });
        pnt.append(panel);        
        pnt.append(accord);

        loadCountryList((d)=>{
            const xs = [];
            d.forEach(x => xs.push({ 
                value: x.name, 
                code: x.code,
                capital: x.capital,
                continent: x.continent
            }));
            const input = $('<input class="countryinput" placeholder="type a country name here">');
            panel.append(input);
            input.autocomplete({
                minLength: 1,
                source: xs,                
                select: function( event, ui ) {
                    pnt.data('item', ui.item );
                    return true;
                }
            })
            .autocomplete( "instance" )._renderItem = function( ul, item ) {
                return $( "<li>" )
                .append(setValue(item))
                .appendTo( ul );
            };
            const addBtn = $(`<button class="ui-button ui-widget ui-corner-all ui-button-icon-only" title="clique para adicionar o país selecionado">
              <span class="ui-icon ui-icon-plusthick"></span> clique para adicionar o país selecionado
            </button>`).click(function(){addCountryPanel(pnt, accord)});
            panel.append(addBtn)
        });

    };

    const addClubSelection = (pnt) =>{
        const panel = $('<div class="club-selection"></div>');
        addCountrySelection(panel);

        pnt.append(panel)
    };

    const load = ()=>{
        /*
        addButton('/Pizza', 'GET', 'GET Teams');
        addButton('/Pizza', 'POST', 'POST Team', {"name":"Calab","isGlutenFree":false});
        addButton('/Pizza/3', 'PUT', 'PUT Team', {"id":"3", "name":"Calabresa"});
        addButton('/Pizza/2', 'DELETE', 'DELETE Team', {});
        */
       const main = $('<div id="main"></div>')

        $('body').append(main);

        addClubSelection(main);
    };

    return {
        load:load
    }
}();

window.onload = CtCtl.load;