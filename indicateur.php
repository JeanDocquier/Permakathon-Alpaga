<!DOCTYPE html>
<html lang="en">

<head>
    <?php include('header.php'); ?>
    <title>PermaFungi - Indicateur</title>
</head>

<body>
    <?php include('menu.php') ?>
    <section id="tableau">
        <div class="selection-tableau">
            <select name="annee-tableau" id="annee-tableau">
                <!-- INSERT OPTION EN FONCTION DE DB -->
                <option value="2019">2019</option>
                <option value="2018">2018</option>
            </select>
            <select name="categorie" id="categorie">
                <!-- INSERT OPTION EN FONCTION DE DB -->
                <option value="financiers">Financier</option>
                <option value="Vente">Vente</option>
            </select>
        </div>
        <div class="le-tableau">
            <table>
                <?php 
                for ($i=0 ; $i < 3 ; $i++){
                    echo '<tr class="nom-class">';
                        for ($j=0 ; $j < 12 ; $j++){
                            echo '<td class>31€</td>';
                        }
                    
                    echo '</tr>';
                }
                
                ?>

            </table>
        </div>
    </section>
    <section id="graphiques">
        <div class="graphique-annuel">
            **INSERT GRAPHIQUE GRAPH.JS**
            <canvas id="myChart">

            </canvas>
        </div>
        <div class="graphique-mensuel">
            <select name="mois-graphique" id="mois-graphique">
                <!-- INSERT OPTION EN FONCTION DE DB -->
                <option value="2019">2019</option>
                <option value="2018">2018</option>
            </select>
            **INSERT GRAPHIQUE GRAPH.JS**

        </div>
    </section>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/Chart.js/2.9.3/Chart.min.js" integrity="sha256-R4pqcOYV8lt7snxMQO/HSbVCFRPMdrhAFMH+vr9giYI=" crossorigin="anonymous"></script>

    <script>
        var ctx = document.getElementById('myChart').getContext('2d');
        var chart = new Chart(ctx, {
            // The type of chart we want to create
            type: 'line',

            // The data for our dataset
            data: {
                labels: ['January', 'February', 'March', 'April', 'May', 'June', 'July'],
                datasets: [{
                    label: 'My First dataset',
                    fill : 2,
                    backgroundColor: 'rgb(255, 99, 132)',
                    borderColor: 'rgb(255, 99, 132)',
                    data: [0, 10, 5, 2, 20, 30, 45]
                }]
            },

            // Configuration options go here
            options: {}
        });

    </script>

    <script src="https://cdnjs.cloudflare.com/ajax/libs/jquery/3.4.1/jquery.min.js" integrity="sha256-CSXorXvZcTkaix6Yvo6HppcZGetbYMGWSFlBw8HfCJo=" crossorigin="anonymous"></script>
    <script src="js/custom.min.js"></script>
</body>

</html>
