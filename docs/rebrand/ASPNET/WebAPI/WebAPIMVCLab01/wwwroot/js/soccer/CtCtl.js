const CtCtl = function() {

    const setValue = item =>`<span class="fi fi-${item.code}"></span><span class="name">${item.value}</span>`;
    const setTeamValue = item =>`<img class="teamicon" src="https://cdn.soccerwiki.org/images/logos/clubs/${item.id}.png"><span class="name">${item.value}</span>`;
    const setTeamTitle = item =>`
        <div class="teamtitle">
            <div><img class="teamicon" src="https://cdn.soccerwiki.org/images/logos/clubs/${item.id}.png"></div>
            <div><div class="teamname">${item.value}</div><div class="teamtitledescription">Founded: ${item.year} Location: ${item.location}</div>
        </div>`;

    const loadCountryList = (cb)=>{
            fetch('/assets/flag-icons/country_v2.json', {
                method: 'GET'
              })
              .then(response => response.json()) 
              .then(cb)
              .catch(err => console.log(err))
    };

    const loadTeamList = (pnt,cb)=>{
        const country = pnt.data('countryItem').code3;
        fetch(`SoccerTeamManager/teamsbycountry/${country}`, {
            method: 'GET'
          })
          .then(response => response.json()) 
          .then(cb)
          .catch(err => console.log(err))
};
    const countrySet = new Map();
    const teamSet = new Map();

    const addCountryPanel = (pnt, accord)=>{
        const item = pnt.data('item');
        if (countrySet.has(item.code)) return;
        countrySet.set(item.code);
        accord.append(`<h3>${setValue(item)}</h3>`);
        const bdy = $(`<div><div class="countryinfo"><div class="description"><div>Continent: ${item.continent}</div><div>Capital: ${item.capital}</div></div></div></div>`);
        accord.append(bdy);        
        pnt.find('.input').val('');        
        const teampanel = $('<div class="teampanel"></div>');
        bdy.append(teampanel);
        teampanel.data('countryItem', item);
        addTeamSelection(teampanel);
        accord.accordion( "refresh");
    };

    const addTeamPanel = (pnt, accord)=>{
        const item = pnt.data('item');
        if (teamSet.has(item.id)) return;
        teamSet.set(item.id);
        accord.append(`<h3>${setTeamTitle(item)}</h3>`);
        const bdy = $(`<div><div class="teaminfo"><div class="description">${item.value} ${item.year} ${item.location}</div></div></div>`);
        accord.append(bdy);        
        pnt.find('.input').val('');        
        const teampanel = $('<div class="teampanel"></div>');
        bdy.append(teampanel);
        accord.accordion( "refresh");
    };

    const addTeamSelection = (pnt)=>{
        const panel = $('<div class="selection"></div>'),
        accord = $('<div class="clubs"></div>').accordion({ collapsible: true, active: false,heightStyle: "fill" });
        pnt.append(panel);        
        pnt.append(accord);

        loadTeamList(pnt,(d)=>{
            const xs = [];
            d.forEach(x => xs.push({ 
                value: x.name, 
                id: x.id,
                year: x.year,
                location: x.location
            }));
            const input = $('<input class="input" placeholder="type a team name here">');
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
                .append(setTeamValue(item))
                .appendTo( ul );
            };
            const addBtn = $(`<button class="ui-button ui-widget ui-corner-all ui-button-icon-only" title="click to append the selected team">
              <span class="ui-icon ui-icon-plusthick"></span> click to append the selected team
            </button>`).click(function(){addTeamPanel(pnt, accord)});
            panel.append(addBtn)
        });

    };

    const addCountrySelection = (pnt)=>{
        const panel = $('<div class="selection"></div>'),
        accord = $('<div class="clubs"></div>').accordion({ collapsible: true, active: false, heightStyle: "fill" });
        pnt.append(panel);        
        pnt.append(accord);

        loadCountryList((d)=>{
            const xs = [];
            d.forEach(x => xs.push({ 
                value: x.name, 
                code: x.code,
                code3: x.code3,
                capital: x.capital,
                continent: x.continent
            }));
            const input = $('<input class="input" placeholder="type a country name here">');
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
            const addBtn = $(`<button class="ui-button ui-widget ui-corner-all ui-button-icon-only" title="click to append the selected team">
              <span class="ui-icon ui-icon-plusthick"></span> click to append the selected team
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