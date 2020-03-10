<!DOCTYPE html>
<html lang="en">

<head>
    <?php include('header.php'); ?>
    <title>PermaFungi - Indicateur</title>
</head>

<body>
    <?php include('menu.php') ?>
    <section id="tableau">
        <h2>Tableau de données</h2>
        <div class="selection-tableau">
            <select class="graph-selecteur" name="annee-tableau" id="annee-tableau">
                <!-- INSERT OPTION EN FONCTION DE DB -->
                <option selected="selected" value="2019">2019</option>
                <option value="2018">2018</option>
            </select>
            <select class="graph-selecteur" name="categorie-tableau" id="categorie-tableau">
                <!-- INSERT OPTION EN FONCTION DE DB -->
                <option selected="selected" value="financiers">Financier</option>
                <option value="Vente">Vente</option>
            </select>
        </div>
        <div class="le-tableau">
            <table>
                <?php 
                for ($i=0 ; $i < 3 ; $i++){
                    echo '<tr class="nom-class">';
                        for ($j=0 ; $j < 12 ; $j++){
                            echo '<td class><input type="number" value="31"></td>';
                        }
                    echo '</tr>';
                }
                
                ?>

            </table>
        </div>
    </section>
    <section id="graphiques">
        <h2>Graphiques</h2>
        <div class="wrapper-graphiques">
            <div class="graphique-annuel">
                <canvas style="height:400px; width:100%" id="graphique-annuel">

                </canvas>


            </div>
            <div class="graphique-mensuel">
                <select class="graph-selecteur" name="mois-graphique" id="mois-graphique">
                    <!-- INSERT OPTION EN FONCTION DE DB -->
                    <option selected="selected" value="Janvier">Janvier</option>
                    <option value="Février">Février</option>
                </select>
                <canvas style="height:400px; width:100%" id="graphique-mensuel">

                </canvas>
            </div>
        </div>
    </section>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/Chart.js/2.9.3/Chart.min.js" integrity="sha256-R4pqcOYV8lt7snxMQO/HSbVCFRPMdrhAFMH+vr9giYI=" crossorigin="anonymous"></script>
    <script src="js/mygraph.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/jquery/3.4.1/jquery.min.js" integrity="sha256-CSXorXvZcTkaix6Yvo6HppcZGetbYMGWSFlBw8HfCJo=" crossorigin="anonymous"></script>
</body>

</html>
