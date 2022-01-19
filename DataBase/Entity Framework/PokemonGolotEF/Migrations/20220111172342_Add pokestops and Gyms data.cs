using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokemonGolotEF.Migrations
{
    public partial class AddpokestopsandGymsdata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "name",
                table: "Gym");

            migrationBuilder.RenameColumn(
                name: "image",
                table: "PokeStop",
                newName: "name");

            migrationBuilder.AddColumn<int>(
                name: "current_level_experience",
                table: "User",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "PokeStop",
                columns: new[] { "location", "name" },
                values: new object[,]
                {
                    { "42,140203#2,45893", "Torre Independentista" },
                    { "42,140909#2,459233", "Parc Infantil 1 d'Octubre" },
                    { "42,141052#2,461108", "Esglesia De Les Presses" },
                    { "42,141384#2,461057", "Restes Monastir" },
                    { "42,141931#2,460739", "La casa de l' heura" },
                    { "42,142457#2,458232", "Antiga Estacio de Tren" },
                    { "42,142807#2,46312", "Piscina Municipal de Les Preses" },
                    { "42,142938#2,461877", "Parc Infantil" },
                    { "42,143114#2,462558", "Ruta Volcà del Racó" },
                    { "42,143571#2,460709", "Camp Municipal d Esports" },
                    { "42,144247#2,571541", "Esglesia de Santa Pau" },
                    { "42,144626#2,460495", "Centre Cultural Les Preses" },
                    { "42,145556#2,457068", "Parc Infantil de Les Preses" },
                    { "42,146228#2,460296", "Dibuix de Sant Sebastià" },
                    { "42,146915#2,458231", "El bressol de Verntallat Les Presses" },
                    { "42,147087#2,461474", "Parc Infantil" },
                    { "42,147908#2,462148", "Parc Infantil Plaça Catalunya" },
                    { "42,14824#2,460987", "Homenatge a la Dona" },
                    { "42,153922#2,516991", "Monument A La Memòria De Joan Maragall" },
                    { "42,155208#2,473602", "Parc infantil de Pocafarina" },
                    { "42,155766#2,473464", "Ruta camins de pedra tosca" },
                    { "42,158847#2,511335", "Parc infantil Can Blanc" },
                    { "42,159115#2,468935", "Pista Esportiva" },
                    { "42,159138#2,473388", "Futbol Bosc De Tosca" },
                    { "42,159343#2,468415", "Font de Boscdetosca" },
                    { "42,159682#2,511221", "Pista de fútbol de Can Blanc" },
                    { "42,163045#2,481201", "Parc de Bonavista" },
                    { "42,1634#2,476778", "Font de la roca volcánica de Bonavista" },
                    { "42,16455#2,487057", "Ruta Fageda d'en Jorda" },
                    { "42,164701#2,480335", "Parc Infantil de Bonavista" },
                    { "42,164719#2,465584", "El Clot De L'infern" },
                    { "42,16472#2,477049", "Vol de Pau" },
                    { "42,16491#2,485357", "Ca La Deu" },
                    { "42,164981#2,4773", "Plaça de Bonavista" },
                    { "42,165063#2,480102", "Homenatge al Camp" },
                    { "42,165068#2,477931", "Pista de Esports" },
                    { "42,165101#2,486097", "Pedra conmemorativa Ramon Bernadas" },
                    { "42,165964#2,466934", "Parc infantil Artiga Bonica" },
                    { "42,166514#2,473046", "Skateboard Olot" },
                    { "42,166612#2,486186", "Sta Ana" },
                    { "42,16674#2,486423", "Turisme Garrotxa a La Moixina" },
                    { "42,166976#2,482283", "Itinerannia Xarxa Via Verda" },
                    { "42,167395#2,47861", "Parc Infantil Bonavista" },
                    { "42,167398#2,480457", "Piscina Municipal" },
                    { "42,167467#2,474953", "Barri de Bonavista" },
                    { "42,167833#2,473439", "Parc Infantil La Solfa" },
                    { "42,168368#2,493534", "Fagedes Entre Volcans" },
                    { "42,168451#2,503385", "Casa Hobbit" },
                    { "42,168528#2,470507", "Parc Plaça de Picasso" },
                    { "42,168586#2,477871", "Parc Infantil de Pekin" },
                    { "42,168591#2,494627", "La Creu del Triai" },
                    { "42,168651#2,499837", "Esglèsia Parroquial De Sant Cristofor Les Fonts" },
                    { "42,168715#2,486777", "Ermita de la Moixina" },
                    { "42,16888#2,483203", "Cocodril de Fusta" },
                    { "42,168897#2,493594", "Espais De Memoria" },
                    { "42,169393#2,503041", "Font de la Vaca" },
                    { "42,169653#2,477541", "Parc De Pekin" },
                    { "42,170146#2,472966", "zona infantil boratosca" },
                    { "42,170236#2,469201", "Font del Anec" },
                    { "42,170274#2,468759", "Camp de Futbol Sant Roc" },
                    { "42,170536#2,479895", "Plantes sense flors i líquens" },
                    { "42,170545#2,473211", "Font de la Plaça Boratosca" },
                    { "42,170689#2,48534", "Finestra a La Garrotxa" },
                    { "42,170809#2,479212", "Ocells del Parc Nou" },
                    { "42,170918#2,471817", "Verge Maria" },
                    { "42,170936#2,487652", "Itineraris de la Moixina" },
                    { "42,171112#2,480345", "Ruta Paratges la Moixina" },
                    { "42,171126#2,481132", "Roureda de roure pènol" },
                    { "42,171244#2,477698", "Font de la plaça Pius XII" },
                    { "42,171287#2,47997", "Museu Dels Volcans" },
                    { "42,171297#2,467279", "pista d'atletisme" },
                    { "42,171491#2,47891", "Els arbres del Parc Nou" },
                    { "42,171649#2,480085", "Fauna del Parc Nou" },
                    { "42,171808#2,481546", "Parc Nou Casal dels Volcans" },
                    { "42,17181#2,481047", "Pere Gussinyé" },
                    { "42,171833#2,475105", "Parc infantil Bosc de la Coma" },
                    { "42,171895#2,480381", "Pont de Fusta" },
                    { "42,172073#2,479094", "Garrotxa cultour" },
                    { "42,172131#2,480003", "Font De La Sardana Al Parc Nou" },
                    { "42,172158#2,48272", "Club Municipal de Tennis Olot" },
                    { "42,172299#2,474416", "Esglesia de Sant Roc" },
                    { "42,172424#2,47983", "Mapa Olot" },
                    { "42,172636#2,479228", "Escultura Maria Compàs" },
                    { "42,17265#2,474387", "La Font de Pedra" },
                    { "42,17295#2,475224", "Centre Civic de Sant Roc" },
                    { "42,172976#2,482529", "Estatua Plaça America" },
                    { "42,17299#2,486636", "Pista d Esports" },
                    { "42,173216#2,472987", "Ermita Sant Roc" },
                    { "42,173218#2,47401", "Parc de Vista Alegre" },
                    { "42,173238#2,482761", "Parc Esportiu" },
                    { "42,173466#2,482519", "Parc Infantil Plaça America" },
                    { "42,173607#2,477856", "El Silo" },
                    { "42,17366#2,474043", "Font De Sant Roc" },
                    { "42,173853#2,475413", "Inici Ruta del Bicicarril" },
                    { "42,174006#2,489988", "Itinerannia xarxa de senders de la Garrotxa" },
                    { "42,174115#2,476329", "Monument en als vençuts" },
                    { "42,174212#2,482304", "Pista de Basquet" },
                    { "42,174244#2,487387", "Area de Salut del Parc de les Mores" },
                    { "42,174341#2,469", "Travesía Tossols-Basil" },
                    { "42,174505#2,475331", "Mare de Deu de l Empenta" },
                    { "42,174563#2,473336", "Monument Club Natació Olot" },
                    { "42,174687#2,483206", "Rocodrom" },
                    { "42,175004#2,479952", "Antiga Estacio de Tren d Olot" },
                    { "42,175048#2,482533", "Escultura J. Henry Dunant" },
                    { "42,175067#2,484298", "Pont de Ferro d'Olot" },
                    { "42,17512#2,486926", "Porta Begoña Uriarte" },
                    { "42,17514#2,488867", "Parc Infantil de les Mores" },
                    { "42,175295#2,4894", "Monumento Parc Espunya" },
                    { "42,175581#2,488922", "Font del Parc de les Mores" },
                    { "42,175602#2,481668", "Monument Funerari Moai" },
                    { "42,175606#2,491831", "Ermita del Pla de l Oruga" },
                    { "42,175945#2,488625", "Itineraris Naturals per la Garrotxa" },
                    { "42,17609#2,488819", "Ruta Volcà de les Bisaroques" },
                    { "42,176229#2,483712", "Parc Infantil Pisos de la Caixa" },
                    { "42,176375#2,489583", "Escacs Ronda Somatent" },
                    { "42,176483#2,478335", "Els Desemparats" },
                    { "42,176557#2,482342", "Font Passeig De Barcelona" },
                    { "42,176627#2,481203", "Monument de Ernest Lluch" },
                    { "42,176772#2,468398", "Montanya Pelada i rutes de senders saludables" },
                    { "42,176826#2,495602", "Canasta de Benavent" },
                    { "42,176848#2,484047", "Escultura en Planxa, Leonci Quera" },
                    { "42,176871#2,481344", "Loro Park" },
                    { "42,177074#2,48927", "Imatge de la Verge del Tura" },
                    { "42,177233#2,49037", "The Graphic Room" },
                    { "42,177293#2,486369", "Escultura a Manel Malagrida" },
                    { "42,177551#2,483017", "Estatua Plaça Manuel Malagrida" },
                    { "42,177647#2,48901", "Font Verge del Tura" },
                    { "42,177817#2,486894", "Escut Escola De Musica" },
                    { "42,177906#2,494768", "Casal Barri Les Fonts" },
                    { "42,178044#2,490228", "Mosaic Ratafia Russet" },
                    { "42,178344#2,49597", "Parc Infantil de Benavent" },
                    { "42,178384#2,488155", "Montserrat" },
                    { "42,178874#2,490906", "Hippo" },
                    { "42,178932#2,494906", "Foment de les Tradicions" },
                    { "42,179018#2,478519", "Torre de defensa Carlina" },
                    { "42,179032#2,484385", "Monument A Joan Pere Fontanella" },
                    { "42,179121#2,488865", "Capella de Sant Roc" },
                    { "42,179306#2,48615", "Escut del cor vermell" },
                    { "42,179476#2,483831", "Xemenia La Coperacio" },
                    { "42,179579#2,491918", "Nostra Senyora Del Tura" },
                    { "42,179727#2,490231", "Sant Antoni De Padua" },
                    { "42,179728#2,484515", "Museu De L'entrepà D'Olot" },
                    { "42,179872#2,497285", "Homenatge a la fira de embotits d'Olot" },
                    { "42,179971#2,48921", "Wom Art Olot" },
                    { "42,180014#2,491824", "Monestir Divina Providencia" },
                    { "42,180041#2,488743", "Joaquim Vayreda" },
                    { "42,180098#2,489013", "Museu dels Sants" },
                    { "42,180346#2,48295", "Parc Infantil de la Hidro" },
                    { "42,180366#2,485257", "Estatua Per La Maternitat. Plaça Clarà." },
                    { "42,180398#2,481319", "Mapa Historic" },
                    { "42,180417#2,484978", "Font Blava" },
                    { "42,180462#2,490827", "Font Del Fluvia" },
                    { "42,180594#2,493782", "Olot Esportiu" },
                    { "42,180603#2,494297", "Gegants Del Barri" },
                    { "42,180615#2,483208", "fundicio ductil benito manlleu" },
                    { "42,180624#2,495599", "Font de Sant Cristofor" },
                    { "42,180657#2,491659", "Estació Bus Olot" },
                    { "42,180679#2,486072", "Mapa Turistic Ciutat D'Olot" },
                    { "42,180731#2,492788", "Itinerari de vells camins de Batet" },
                    { "42,18075#2,487011", "Establiment Històric Curós Espigulé SL. 1965" },
                    { "42,180774#2,484477", "Escolàpies d'Olot" },
                    { "42,180816#2,487678", "Antic Hospital d Olot 700 Aniversari" },
                    { "42,180895#2,488355", "Plaça Mercat 2" },
                    { "42,180933#2,47943", "Torre de Vigilancia" },
                    { "42,180977#2,477426", "Font de la Placeta" },
                    { "42,180977#2,488705", "parc infaltil dels coloms" },
                    { "42,181057#2,49887", "Palamós 1989" },
                    { "42,181086#2,491292", "Mapa d'Olot" },
                    { "42,181174#2,486553", "Esglesia Sant Rafael" },
                    { "42,181177#2,489128", "De. Candi in Memoriam" },
                    { "42,181235#2,485507", "Capella de Sant Ferriol" },
                    { "42,18129#2,489679", "Edifici Hospici" },
                    { "42,181291#2,49729", "Area de Salut de les Bisaroques" },
                    { "42,181298#2,484955", "Parc Infantil Plaça Clara" },
                    { "42,181439#2,491707", "Escultura Carbonell d'Olot" },
                    { "42,181452#2,492522", "San Kirinoies" },
                    { "42,181453#2,4941", "Sant Cristofor" },
                    { "42,181498#2,488108", "Ràdio Olot" },
                    { "42,181542#2,48719", "Vernio" },
                    { "42,181563#2,490688", "Rescat a la Natura" },
                    { "42,181609#2,489535", "Escultura de Sant Antoni de Padua" },
                    { "42,181651#2,477238", "Escultura Jardi Lluis Planella" },
                    { "42,181803#2,488183", "Estatua Placida" },
                    { "42,181804#2,487565", "Casa Natal Joseph Clarà" },
                    { "42,181868#2,489382", "Plaça De L'àngel" },
                    { "42,181921#2,488742", "Nena Que Mira Enlaire" },
                    { "42,181931#2,490396", "Imatge De Sant Albert" },
                    { "42,181931#2,491578", "Font De Valls Nous" },
                    { "42,181951#2,486179", "Casa Noucentista" },
                    { "42,181964#2,486938", "Font de la plaça del Teatre" },
                    { "42,181989#2,485609", "Sant Pere Martir" },
                    { "42,181998#2,490919", "Estàtua de la Mare de Déu del Tura" },
                    { "42,182031#2,493127", "Santa Magdalena Del Pont" },
                    { "42,182042#2,484682", "Font Sant Pere Martir" },
                    { "42,182067#2,489169", "Biblioteca Marià Vayreda" },
                    { "42,182089#2,483645", "Edifici Roc Blanc" },
                    { "42,182209#2,492468", "Font Zona Verda Santa Magdalena" },
                    { "42,182214#2,490716", "Plaça De La Pia Almonia" },
                    { "42,18228#2,491355", "Escut Família" },
                    { "42,182282#2,489496", "Ca L'Albert" },
                    { "42,182286#2,478306", "St. Pere Màrtir" },
                    { "42,182295#2,488093", "Escultura a Manuel Traité" },
                    { "42,182339#2,486748", "Homenaje a Cándida Pérez" },
                    { "42,182373#2,491866", "Església del Tura" },
                    { "42,182443#2,489213", "Can Japot" },
                    { "42,182488#2,479496", "Font Plaça Doctor Fleming" },
                    { "42,182502#2,482175", "Ruta Volcà Montsacopa i Montolivet" },
                    { "42,182521#2,494003", "Molí antic del riu fluvia" },
                    { "42,182531#2,488234", "Contemplant" },
                    { "42,182538#2,494664", "Parc Infantil Miquel Marti Pol" },
                    { "42,182628#2,470488", "Parc Esportiu Plaça Pla de Dalt" },
                    { "42,182638#2,47662", "Homenatge a la dona Treballadora" },
                    { "42,18268#2,493328", "Consell Comarcal de la Garrotxa" },
                    { "42,1827#2,490694", "Homenatge al carnaval d'Olot" },
                    { "42,18271#2,487339", "Teatre Principal" },
                    { "42,182733#2,485017", "Esglesia Nostre Dona del Tura" },
                    { "42,182789#2,484181", "Casal Maria" },
                    { "42,182798#2,488817", "Cor de Maria" },
                    { "42,182798#2,491343", "Font del Conill" },
                    { "42,182832#2,478917", "Monument Rosa Serra" },
                    { "42,182833#2,494928", "Monument Miquel Martí i Pol" },
                    { "42,182901#2,471903", "Pou ornamental del Pla de Dalt" },
                    { "42,182919#2,491632", "El Drac" },
                    { "42,182949#2,492807", "Parc Infantil del Palau" },
                    { "42,183002#2,491006", "Can Boquica" },
                    { "42,183006#2,496606", "Art urbà" },
                    { "42,183014#2,476441", "Entrada Barri SPM" },
                    { "42,183066#2,489279", "Grafiti Cal Pirata" },
                    { "42,183095#2,48482", "Olot Indepe" },
                    { "42,183111#2,484467", "Ajuntament" },
                    { "42,18314#2,493878", "Consorci d Accio Social" },
                    { "42,18319#2,470148", "Parc infantil Pla de Dalt" },
                    { "42,183196#2,486619", "Estatua De Miquel Blay" },
                    { "42,183217#2,492051", "Església Del Carme" },
                    { "42,183272#2,493631", "Monument Plaça Palau" },
                    { "42,183318#2,48981", "Plaça De Les Monjes" },
                    { "42,183344#2,490676", "Aigua" },
                    { "42,183368#2,483292", "Esglesia Testigos de Jehova" },
                    { "42,183368#2,4872", "Volcans del terme municipal d'Olot" },
                    { "42,18339#2,49869", "Església Bíblica d'Olot" },
                    { "42,183414#2,486297", "Escultura L'Origen" },
                    { "42,183437#2,492668", "Ateneu Central D'olot" },
                    { "42,183453#2,471427", "Font del Puig" },
                    { "42,183478#2,457388", "Parc infantil de la Garrotxa" },
                    { "42,183519#2,489716", "Edifici del Ganxet" },
                    { "42,183551#2,490952", "Pista Esportiva Nucli Antic" },
                    { "42,183617#2,490619", "Campdenmas" },
                    { "42,183673#2,484202", "Antiga Muralla de Defensa" },
                    { "42,183719#2,483792", "Esglesia Protestant" },
                    { "42,183748#2,485099", "Monument Al Rotary Club" },
                    { "42,18383#2,482699", "Plaça Balmes" },
                    { "42,183864#2,485952", "Arxiu Comarcal de la Garrotxa" },
                    { "42,183906#2,465914", "Parc Infantil Les Planotes" },
                    { "42,184003#2,467161", "Font del xiprer" },
                    { "42,184043#2,48115", "Olot sense correbous" },
                    { "42,184087#2,485513", "Estrella Mal Acabada" },
                    { "42,184181#2,471866", "Escultura del Pla de Dalt" },
                    { "42,184182#2,482166", "Mosaic dels segadors" },
                    { "42,184199#2,491673", "Font De Sant Bernat" },
                    { "42,184308#2,494592", "Sant Miquel" },
                    { "42,184317#2,485641", "Plaça de Toros" },
                    { "42,184523#2,481113", "Esglesia Cristiana Evangelica" },
                    { "42,184597#2,483882", "lucky luke" },
                    { "42,184663#2,463171", "Pista de bàsquet" },
                    { "42,18474#2,461585", "Parc de Les Planotes" },
                    { "42,184785#2,488642", "Figura De Sant Andreu" },
                    { "42,184787#2,486647", "Bust Desfigurat" },
                    { "42,18501#2,49247", "Capella de Sant Bernat" },
                    { "42,185053#2,472865", "Parc del Pla de Dalt" },
                    { "42,185128#2,482716", "escola municipal d'expressiö" },
                    { "42,185129#2,484677", "Muralla Carlina" },
                    { "42,185212#2,491034", "Montsacopa" },
                    { "42,18523#2,486272", "Monument d'homenatge als Morts" },
                    { "42,185455#2,486172", "Cementiri d'Olot" },
                    { "42,185468#2,491081", "Viacrucis Montsacopa III" },
                    { "42,185562#2,494867", "Penya Barcelonista d’Olot" },
                    { "42,185787#2,495406", "Font Juan Casula Vilanova" },
                    { "42,185794#2,487733", "Espai moseistic del volcà del montsacopa" },
                    { "42,185831#2,497779", "Agrupament Escolta Nostra Dona Del Tura" },
                    { "42,185983#2,485648", "Turisme Garrotxa" },
                    { "42,185993#2,496586", "Xarxa D'itineraris Saludables" },
                    { "42,186042#2,492402", "Font De La Nena" },
                    { "42,186059#2,493079", "Memoria Vestits Tradicionals" },
                    { "42,186149#2,472613", "Camp de Futbol Joventut SPM" },
                    { "42,186527#2,497117", "Tornaboda" },
                    { "42,186679#2,479641", "Caseta dels Burots" },
                    { "42,186927#2,488417", "Creu del volcà Montsacopa" },
                    { "42,186987#2,4865", "Estrats De Reserva" },
                    { "42,186993#2,494968", "Mesquita al rahma de la garrotxa" },
                    { "42,187125#2,468216", "Monument als Donants de Sang" },
                    { "42,187126#2,488204", "Capella de la Roca Volcànica" },
                    { "42,187158#2,488537", "Església al Volcà del Montsacopa" },
                    { "42,187217#2,468935", "Area de Salut Pla de Dalt" },
                    { "42,187263#2,497006", "Servicio Moto Guzzi" },
                    { "42,187407#2,494926", "En Honor A Leonci Quera" },
                    { "42,187509#2,49555", "Parc Infantil Sant Miquel" },
                    { "42,187959#2,471217", "Centre Meteorologic Pla de Dalt" },
                    { "42,188111#2,48941", "Montsacopa" },
                    { "42,188232#2,509423", "Camp de futbol les tries" },
                    { "42,188259#2,489509", "Torre Dels Carlins" },
                    { "42,188282#2,499454", "Parc Infantil de la Rodona" },
                    { "42,188284#2,494975", "Relotge d en Clara" },
                    { "42,188308#2,511355", "Font de les Tries" },
                    { "42,18832#2,487904", "Torre Nord de Sant Francesc. Segle XVIII" },
                    { "42,189074#2,500672", "El Raïm garrotxí" },
                    { "42,18917#2,498544", "Panell Cultural De La Ciutat" },
                    { "42,189257#2,505546", "Parc Infantil Mestre Falla" },
                    { "42,189446#2,50946", "La torre del Club Natació Olot" },
                    { "42,18958#2,476024", "Estadi Municipal d Olot" },
                    { "42,189583#2,499194", "Zona Verda d Esplai Mestre Moner" },
                    { "42,18966#2,485404", "Homenatge als nens" },
                    { "42,189745#2,510175", "Parque infantil Les Tries" },
                    { "42,189932#2,500812", "Parc Infantil Alba Rosa" },
                    { "42,189992#2,484391", "Parc Infantil del Morrot" },
                    { "42,190078#2,484673", "Font De Roca Volcànica" },
                    { "42,190087#2,478243", "Escultura Al Treball" },
                    { "42,190195#2,481211", "Camp de Futbol Pla de Baix" },
                    { "42,190242#2,478696", "Cami Natural per bicicletes i vianants" },
                    { "42,190278#2,498496", "Memoria Al Ball Pla Sant Miquel" },
                    { "42,190554#2,483438", "Parc Infantil Pla de Baix" },
                    { "42,190588#2,502526", "Monument Ca Espunya" },
                    { "42,19193#2,503457", "Camp de Futbol de Les Mates" },
                    { "42,19205#2,508972", "Homenatge al Cant dels Ocells" },
                    { "42,192088#2,485779", "Temple \"Gurudwara bhai mardana ji\"" },
                    { "42,192092#2,488654", "Sant Antoni Abad" },
                    { "42,192187#2,486873", "Escultura a Arturo Simon" },
                    { "42,192291#2,500477", "Columna de l'Alba" },
                    { "42,192587#2,508627", "Parc dels Ocells" },
                    { "42,192937#2,504372", "Centre Civic Mas les Mates" },
                    { "42,192947#2,477383", "Parc Infantil Hostal del Sol" },
                    { "42,193153#2,5031", "Font de les Mates" },
                    { "42,193427#2,483063", "Homenatge a la Revolucio Industrial" },
                    { "42,194901#2,489883", "Parc de la Ruta del Carrilet" },
                    { "42,202943#2,497735", "Parc infantil carretera Olot" },
                    { "42,204479#2,494618", "Parc Infantil La Canya" },
                    { "42,204663#2,49247", "Ermita d'Esperança" },
                    { "42,20507#2,494422", "La Canya circuit de rehabilitació" },
                    { "42,205493#2,493214", "Camp de futbol la Canya" },
                    { "42,206018#2,492983", "Església de La Canya" },
                    { "42,207574#2,494876", "La casa de los navarros" },
                    { "42,208799#2,491924", "Parc infantil carretera Bianya" },
                    { "42,209885#2,492", "Camp de Futbol de La Canya" },
                    { "42,211312#2,513696", "Familia" },
                    { "42,211491#2,514822", "La Casa Extranya" },
                    { "42,212438#2,511442", "Monument A La Industria I Cultura" },
                    { "42,212552#2,511057", "Ajuntament Sant Joan Les Fonts" },
                    { "42,212593#2,509454", "pont medieval" },
                    { "42,212753#2,512207", "Parc Infantil" },
                    { "42,21307#2,509031", "Monestir De Sant Joan" },
                    { "42,213478#2,509039", "Absis Catedral Sant Joan" },
                    { "42,214354#2,50968", "mapa Molí Fondo" },
                    { "42,215052#2,510166", "Pedrera Del Boscarro" },
                    { "42,216145#2,511136", "Poblat Iberic La Societat" },
                    { "42,217585#2,515104", "Monestir de Sant Joan de les Fonts" }
                });

            migrationBuilder.InsertData(
                table: "Gym",
                columns: new[] { "location", "team" },
                values: new object[,]
                {
                    { "42,140909#2,459233", null },
                    { "42,141931#2,460739", null },
                    { "42,142938#2,461877", null },
                    { "42,144247#2,571541", null },
                    { "42,146915#2,458231", null },
                    { "42,147908#2,462148", null },
                    { "42,163045#2,481201", null },
                    { "42,165063#2,480102", null },
                    { "42,166612#2,486186", null },
                    { "42,167398#2,480457", null },
                    { "42,168368#2,493534", null },
                    { "42,168528#2,470507", null },
                    { "42,169393#2,503041", null },
                    { "42,169653#2,477541", null },
                    { "42,170236#2,469201", null },
                    { "42,170545#2,473211", null },
                    { "42,170689#2,48534", null },
                    { "42,171244#2,477698", null },
                    { "42,171287#2,47997", null },
                    { "42,17181#2,481047", null },
                    { "42,172976#2,482529", null },
                    { "42,17366#2,474043", null },
                    { "42,174341#2,469", null },
                    { "42,175004#2,479952", null },
                    { "42,175295#2,4894", null },
                    { "42,175602#2,481668", null },
                    { "42,177293#2,486369", null },
                    { "42,177551#2,483017", null },
                    { "42,177906#2,494768", null },
                    { "42,178932#2,494906", null },
                    { "42,180366#2,485257", null },
                    { "42,180624#2,495599", null },
                    { "42,181452#2,492522", null },
                    { "42,181803#2,488183", null },
                    { "42,181868#2,489382", null },
                    { "42,182286#2,478306", null },
                    { "42,182488#2,479496", null },
                    { "42,183006#2,496606", null },
                    { "42,183095#2,48482", null },
                    { "42,183344#2,490676", null },
                    { "42,183437#2,492668", null },
                    { "42,183748#2,485099", null },
                    { "42,184181#2,471866", null },
                    { "42,184663#2,463171", null },
                    { "42,185129#2,484677", null },
                    { "42,186042#2,492402", null },
                    { "42,186149#2,472613", null },
                    { "42,186527#2,497117", null },
                    { "42,186987#2,4865", null },
                    { "42,187217#2,468935", null },
                    { "42,187263#2,497006", null },
                    { "42,188259#2,489509", null },
                    { "42,188284#2,494975", null },
                    { "42,189583#2,499194", null },
                    { "42,190078#2,484673", null },
                    { "42,190087#2,478243", null },
                    { "42,192092#2,488654", null },
                    { "42,192291#2,500477", null },
                    { "42,192587#2,508627", null },
                    { "42,206018#2,492983", null },
                    { "42,207574#2,494876", null },
                    { "42,211312#2,513696", null },
                    { "42,21307#2,509031", null },
                    { "42,216145#2,511136", null },
                    { "42,217585#2,515104", null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Gym",
                keyColumn: "location",
                keyValue: "42,140909#2,459233");

            migrationBuilder.DeleteData(
                table: "Gym",
                keyColumn: "location",
                keyValue: "42,141931#2,460739");

            migrationBuilder.DeleteData(
                table: "Gym",
                keyColumn: "location",
                keyValue: "42,142938#2,461877");

            migrationBuilder.DeleteData(
                table: "Gym",
                keyColumn: "location",
                keyValue: "42,144247#2,571541");

            migrationBuilder.DeleteData(
                table: "Gym",
                keyColumn: "location",
                keyValue: "42,146915#2,458231");

            migrationBuilder.DeleteData(
                table: "Gym",
                keyColumn: "location",
                keyValue: "42,147908#2,462148");

            migrationBuilder.DeleteData(
                table: "Gym",
                keyColumn: "location",
                keyValue: "42,163045#2,481201");

            migrationBuilder.DeleteData(
                table: "Gym",
                keyColumn: "location",
                keyValue: "42,165063#2,480102");

            migrationBuilder.DeleteData(
                table: "Gym",
                keyColumn: "location",
                keyValue: "42,166612#2,486186");

            migrationBuilder.DeleteData(
                table: "Gym",
                keyColumn: "location",
                keyValue: "42,167398#2,480457");

            migrationBuilder.DeleteData(
                table: "Gym",
                keyColumn: "location",
                keyValue: "42,168368#2,493534");

            migrationBuilder.DeleteData(
                table: "Gym",
                keyColumn: "location",
                keyValue: "42,168528#2,470507");

            migrationBuilder.DeleteData(
                table: "Gym",
                keyColumn: "location",
                keyValue: "42,169393#2,503041");

            migrationBuilder.DeleteData(
                table: "Gym",
                keyColumn: "location",
                keyValue: "42,169653#2,477541");

            migrationBuilder.DeleteData(
                table: "Gym",
                keyColumn: "location",
                keyValue: "42,170236#2,469201");

            migrationBuilder.DeleteData(
                table: "Gym",
                keyColumn: "location",
                keyValue: "42,170545#2,473211");

            migrationBuilder.DeleteData(
                table: "Gym",
                keyColumn: "location",
                keyValue: "42,170689#2,48534");

            migrationBuilder.DeleteData(
                table: "Gym",
                keyColumn: "location",
                keyValue: "42,171244#2,477698");

            migrationBuilder.DeleteData(
                table: "Gym",
                keyColumn: "location",
                keyValue: "42,171287#2,47997");

            migrationBuilder.DeleteData(
                table: "Gym",
                keyColumn: "location",
                keyValue: "42,17181#2,481047");

            migrationBuilder.DeleteData(
                table: "Gym",
                keyColumn: "location",
                keyValue: "42,172976#2,482529");

            migrationBuilder.DeleteData(
                table: "Gym",
                keyColumn: "location",
                keyValue: "42,17366#2,474043");

            migrationBuilder.DeleteData(
                table: "Gym",
                keyColumn: "location",
                keyValue: "42,174341#2,469");

            migrationBuilder.DeleteData(
                table: "Gym",
                keyColumn: "location",
                keyValue: "42,175004#2,479952");

            migrationBuilder.DeleteData(
                table: "Gym",
                keyColumn: "location",
                keyValue: "42,175295#2,4894");

            migrationBuilder.DeleteData(
                table: "Gym",
                keyColumn: "location",
                keyValue: "42,175602#2,481668");

            migrationBuilder.DeleteData(
                table: "Gym",
                keyColumn: "location",
                keyValue: "42,177293#2,486369");

            migrationBuilder.DeleteData(
                table: "Gym",
                keyColumn: "location",
                keyValue: "42,177551#2,483017");

            migrationBuilder.DeleteData(
                table: "Gym",
                keyColumn: "location",
                keyValue: "42,177906#2,494768");

            migrationBuilder.DeleteData(
                table: "Gym",
                keyColumn: "location",
                keyValue: "42,178932#2,494906");

            migrationBuilder.DeleteData(
                table: "Gym",
                keyColumn: "location",
                keyValue: "42,180366#2,485257");

            migrationBuilder.DeleteData(
                table: "Gym",
                keyColumn: "location",
                keyValue: "42,180624#2,495599");

            migrationBuilder.DeleteData(
                table: "Gym",
                keyColumn: "location",
                keyValue: "42,181452#2,492522");

            migrationBuilder.DeleteData(
                table: "Gym",
                keyColumn: "location",
                keyValue: "42,181803#2,488183");

            migrationBuilder.DeleteData(
                table: "Gym",
                keyColumn: "location",
                keyValue: "42,181868#2,489382");

            migrationBuilder.DeleteData(
                table: "Gym",
                keyColumn: "location",
                keyValue: "42,182286#2,478306");

            migrationBuilder.DeleteData(
                table: "Gym",
                keyColumn: "location",
                keyValue: "42,182488#2,479496");

            migrationBuilder.DeleteData(
                table: "Gym",
                keyColumn: "location",
                keyValue: "42,183006#2,496606");

            migrationBuilder.DeleteData(
                table: "Gym",
                keyColumn: "location",
                keyValue: "42,183095#2,48482");

            migrationBuilder.DeleteData(
                table: "Gym",
                keyColumn: "location",
                keyValue: "42,183344#2,490676");

            migrationBuilder.DeleteData(
                table: "Gym",
                keyColumn: "location",
                keyValue: "42,183437#2,492668");

            migrationBuilder.DeleteData(
                table: "Gym",
                keyColumn: "location",
                keyValue: "42,183748#2,485099");

            migrationBuilder.DeleteData(
                table: "Gym",
                keyColumn: "location",
                keyValue: "42,184181#2,471866");

            migrationBuilder.DeleteData(
                table: "Gym",
                keyColumn: "location",
                keyValue: "42,184663#2,463171");

            migrationBuilder.DeleteData(
                table: "Gym",
                keyColumn: "location",
                keyValue: "42,185129#2,484677");

            migrationBuilder.DeleteData(
                table: "Gym",
                keyColumn: "location",
                keyValue: "42,186042#2,492402");

            migrationBuilder.DeleteData(
                table: "Gym",
                keyColumn: "location",
                keyValue: "42,186149#2,472613");

            migrationBuilder.DeleteData(
                table: "Gym",
                keyColumn: "location",
                keyValue: "42,186527#2,497117");

            migrationBuilder.DeleteData(
                table: "Gym",
                keyColumn: "location",
                keyValue: "42,186987#2,4865");

            migrationBuilder.DeleteData(
                table: "Gym",
                keyColumn: "location",
                keyValue: "42,187217#2,468935");

            migrationBuilder.DeleteData(
                table: "Gym",
                keyColumn: "location",
                keyValue: "42,187263#2,497006");

            migrationBuilder.DeleteData(
                table: "Gym",
                keyColumn: "location",
                keyValue: "42,188259#2,489509");

            migrationBuilder.DeleteData(
                table: "Gym",
                keyColumn: "location",
                keyValue: "42,188284#2,494975");

            migrationBuilder.DeleteData(
                table: "Gym",
                keyColumn: "location",
                keyValue: "42,189583#2,499194");

            migrationBuilder.DeleteData(
                table: "Gym",
                keyColumn: "location",
                keyValue: "42,190078#2,484673");

            migrationBuilder.DeleteData(
                table: "Gym",
                keyColumn: "location",
                keyValue: "42,190087#2,478243");

            migrationBuilder.DeleteData(
                table: "Gym",
                keyColumn: "location",
                keyValue: "42,192092#2,488654");

            migrationBuilder.DeleteData(
                table: "Gym",
                keyColumn: "location",
                keyValue: "42,192291#2,500477");

            migrationBuilder.DeleteData(
                table: "Gym",
                keyColumn: "location",
                keyValue: "42,192587#2,508627");

            migrationBuilder.DeleteData(
                table: "Gym",
                keyColumn: "location",
                keyValue: "42,206018#2,492983");

            migrationBuilder.DeleteData(
                table: "Gym",
                keyColumn: "location",
                keyValue: "42,207574#2,494876");

            migrationBuilder.DeleteData(
                table: "Gym",
                keyColumn: "location",
                keyValue: "42,211312#2,513696");

            migrationBuilder.DeleteData(
                table: "Gym",
                keyColumn: "location",
                keyValue: "42,21307#2,509031");

            migrationBuilder.DeleteData(
                table: "Gym",
                keyColumn: "location",
                keyValue: "42,216145#2,511136");

            migrationBuilder.DeleteData(
                table: "Gym",
                keyColumn: "location",
                keyValue: "42,217585#2,515104");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,140203#2,45893");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,141052#2,461108");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,141384#2,461057");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,142457#2,458232");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,142807#2,46312");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,143114#2,462558");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,143571#2,460709");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,144626#2,460495");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,145556#2,457068");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,146228#2,460296");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,147087#2,461474");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,14824#2,460987");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,153922#2,516991");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,155208#2,473602");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,155766#2,473464");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,158847#2,511335");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,159115#2,468935");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,159138#2,473388");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,159343#2,468415");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,159682#2,511221");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,1634#2,476778");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,16455#2,487057");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,164701#2,480335");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,164719#2,465584");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,16472#2,477049");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,16491#2,485357");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,164981#2,4773");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,165068#2,477931");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,165101#2,486097");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,165964#2,466934");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,166514#2,473046");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,16674#2,486423");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,166976#2,482283");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,167395#2,47861");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,167467#2,474953");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,167833#2,473439");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,168451#2,503385");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,168586#2,477871");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,168591#2,494627");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,168651#2,499837");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,168715#2,486777");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,16888#2,483203");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,168897#2,493594");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,170146#2,472966");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,170274#2,468759");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,170536#2,479895");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,170809#2,479212");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,170918#2,471817");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,170936#2,487652");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,171112#2,480345");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,171126#2,481132");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,171297#2,467279");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,171491#2,47891");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,171649#2,480085");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,171808#2,481546");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,171833#2,475105");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,171895#2,480381");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,172073#2,479094");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,172131#2,480003");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,172158#2,48272");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,172299#2,474416");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,172424#2,47983");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,172636#2,479228");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,17265#2,474387");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,17295#2,475224");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,17299#2,486636");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,173216#2,472987");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,173218#2,47401");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,173238#2,482761");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,173466#2,482519");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,173607#2,477856");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,173853#2,475413");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,174006#2,489988");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,174115#2,476329");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,174212#2,482304");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,174244#2,487387");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,174505#2,475331");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,174563#2,473336");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,174687#2,483206");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,175048#2,482533");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,175067#2,484298");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,17512#2,486926");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,17514#2,488867");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,175581#2,488922");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,175606#2,491831");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,175945#2,488625");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,17609#2,488819");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,176229#2,483712");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,176375#2,489583");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,176483#2,478335");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,176557#2,482342");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,176627#2,481203");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,176772#2,468398");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,176826#2,495602");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,176848#2,484047");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,176871#2,481344");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,177074#2,48927");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,177233#2,49037");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,177647#2,48901");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,177817#2,486894");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,178044#2,490228");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,178344#2,49597");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,178384#2,488155");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,178874#2,490906");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,179018#2,478519");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,179032#2,484385");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,179121#2,488865");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,179306#2,48615");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,179476#2,483831");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,179579#2,491918");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,179727#2,490231");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,179728#2,484515");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,179872#2,497285");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,179971#2,48921");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,180014#2,491824");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,180041#2,488743");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,180098#2,489013");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,180346#2,48295");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,180398#2,481319");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,180417#2,484978");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,180462#2,490827");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,180594#2,493782");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,180603#2,494297");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,180615#2,483208");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,180657#2,491659");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,180679#2,486072");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,180731#2,492788");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,18075#2,487011");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,180774#2,484477");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,180816#2,487678");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,180895#2,488355");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,180933#2,47943");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,180977#2,477426");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,180977#2,488705");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,181057#2,49887");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,181086#2,491292");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,181174#2,486553");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,181177#2,489128");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,181235#2,485507");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,18129#2,489679");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,181291#2,49729");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,181298#2,484955");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,181439#2,491707");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,181453#2,4941");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,181498#2,488108");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,181542#2,48719");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,181563#2,490688");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,181609#2,489535");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,181651#2,477238");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,181804#2,487565");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,181921#2,488742");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,181931#2,490396");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,181931#2,491578");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,181951#2,486179");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,181964#2,486938");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,181989#2,485609");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,181998#2,490919");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,182031#2,493127");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,182042#2,484682");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,182067#2,489169");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,182089#2,483645");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,182209#2,492468");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,182214#2,490716");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,18228#2,491355");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,182282#2,489496");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,182295#2,488093");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,182339#2,486748");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,182373#2,491866");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,182443#2,489213");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,182502#2,482175");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,182521#2,494003");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,182531#2,488234");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,182538#2,494664");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,182628#2,470488");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,182638#2,47662");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,18268#2,493328");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,1827#2,490694");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,18271#2,487339");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,182733#2,485017");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,182789#2,484181");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,182798#2,488817");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,182798#2,491343");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,182832#2,478917");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,182833#2,494928");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,182901#2,471903");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,182919#2,491632");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,182949#2,492807");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,183002#2,491006");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,183014#2,476441");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,183066#2,489279");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,183111#2,484467");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,18314#2,493878");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,18319#2,470148");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,183196#2,486619");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,183217#2,492051");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,183272#2,493631");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,183318#2,48981");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,183368#2,483292");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,183368#2,4872");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,18339#2,49869");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,183414#2,486297");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,183453#2,471427");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,183478#2,457388");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,183519#2,489716");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,183551#2,490952");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,183617#2,490619");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,183673#2,484202");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,183719#2,483792");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,18383#2,482699");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,183864#2,485952");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,183906#2,465914");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,184003#2,467161");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,184043#2,48115");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,184087#2,485513");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,184182#2,482166");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,184199#2,491673");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,184308#2,494592");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,184317#2,485641");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,184523#2,481113");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,184597#2,483882");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,18474#2,461585");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,184785#2,488642");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,184787#2,486647");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,18501#2,49247");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,185053#2,472865");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,185128#2,482716");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,185212#2,491034");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,18523#2,486272");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,185455#2,486172");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,185468#2,491081");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,185562#2,494867");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,185787#2,495406");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,185794#2,487733");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,185831#2,497779");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,185983#2,485648");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,185993#2,496586");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,186059#2,493079");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,186679#2,479641");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,186927#2,488417");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,186993#2,494968");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,187125#2,468216");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,187126#2,488204");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,187158#2,488537");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,187407#2,494926");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,187509#2,49555");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,187959#2,471217");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,188111#2,48941");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,188232#2,509423");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,188282#2,499454");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,188308#2,511355");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,18832#2,487904");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,189074#2,500672");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,18917#2,498544");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,189257#2,505546");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,189446#2,50946");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,18958#2,476024");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,18966#2,485404");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,189745#2,510175");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,189932#2,500812");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,189992#2,484391");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,190195#2,481211");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,190242#2,478696");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,190278#2,498496");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,190554#2,483438");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,190588#2,502526");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,19193#2,503457");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,19205#2,508972");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,192088#2,485779");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,192187#2,486873");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,192937#2,504372");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,192947#2,477383");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,193153#2,5031");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,193427#2,483063");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,194901#2,489883");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,202943#2,497735");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,204479#2,494618");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,204663#2,49247");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,20507#2,494422");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,205493#2,493214");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,208799#2,491924");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,209885#2,492");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,211491#2,514822");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,212438#2,511442");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,212552#2,511057");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,212593#2,509454");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,212753#2,512207");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,213478#2,509039");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,214354#2,50968");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,215052#2,510166");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,140909#2,459233");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,141931#2,460739");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,142938#2,461877");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,144247#2,571541");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,146915#2,458231");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,147908#2,462148");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,163045#2,481201");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,165063#2,480102");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,166612#2,486186");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,167398#2,480457");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,168368#2,493534");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,168528#2,470507");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,169393#2,503041");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,169653#2,477541");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,170236#2,469201");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,170545#2,473211");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,170689#2,48534");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,171244#2,477698");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,171287#2,47997");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,17181#2,481047");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,172976#2,482529");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,17366#2,474043");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,174341#2,469");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,175004#2,479952");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,175295#2,4894");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,175602#2,481668");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,177293#2,486369");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,177551#2,483017");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,177906#2,494768");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,178932#2,494906");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,180366#2,485257");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,180624#2,495599");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,181452#2,492522");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,181803#2,488183");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,181868#2,489382");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,182286#2,478306");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,182488#2,479496");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,183006#2,496606");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,183095#2,48482");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,183344#2,490676");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,183437#2,492668");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,183748#2,485099");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,184181#2,471866");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,184663#2,463171");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,185129#2,484677");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,186042#2,492402");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,186149#2,472613");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,186527#2,497117");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,186987#2,4865");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,187217#2,468935");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,187263#2,497006");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,188259#2,489509");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,188284#2,494975");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,189583#2,499194");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,190078#2,484673");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,190087#2,478243");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,192092#2,488654");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,192291#2,500477");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,192587#2,508627");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,206018#2,492983");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,207574#2,494876");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,211312#2,513696");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,21307#2,509031");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,216145#2,511136");

            migrationBuilder.DeleteData(
                table: "PokeStop",
                keyColumn: "location",
                keyValue: "42,217585#2,515104");

            migrationBuilder.DropColumn(
                name: "current_level_experience",
                table: "User");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "PokeStop",
                newName: "image");

            migrationBuilder.AddColumn<string>(
                name: "name",
                table: "Gym",
                type: "text",
                nullable: false,
                defaultValue: "");
        }
    }
}
