<!DOCTYPE html>
<html lang="en">

<head>
    <?php include('header.php'); ?>
    <title>PermaFungi - Indicateur</title>
</head>

<body>
    <?php include('menu.php') ?>

    <section id="graphiques">
        <h2>Graphiques</h2>
        <div class="selection-tableau">
            <select class="graph-selecteur" name="annee-tableau" id="annee-tableau">
                <!-- INSERT OPTION EN FONCTION DE DB -->
                <option value="2018">2018</option>
            </select>
            <select class="graph-selecteur" name="categorie-tableau" id="categorie-tableau">
                <!-- INSERT OPTION EN FONCTION DE DB -->
                <option selected="selected" value="production">Production</option>
                <option value="ventes">Ventes</option>
            </select>
        </div>
        <div class="wrapper-graphiques">
            <div class="graphique-annuel">
                <canvas style="height:400px; width:100%" id="graphique-annuel">

                </canvas>


            </div>
<!--
            <div class="graphique-mensuel">
                <select class="graph-selecteur" name="mois-graphique" id="mois-graphique">
                     INSERT OPTION EN FONCTION DE DB 
                    <option selected="selected" value="0">Janvier</option>
                    <option value="1">Février</option>
                    <option value="2">Mars</option>
                    <option value="3">Avril</option>
                    <option value="4">Mai</option>
                    <option value="5">Juin</option>
                    <option value="6">Juillet</option>
                    <option value="7">Aout</option>
                    <option value="8">Septembre</option>
                    <option value="9">Octobre</option>
                    <option value="10">Novembre</option>
                    <option value="11">Décembre</option>
                </select>
                <canvas style="height:400px; width:100%" id="graphique-mensuel">

                </canvas>
            </div>
-->
        </div>
    </section>
    <section id="tableau">
        <h2>Tableau de données</h2>
        <div class="le-tableau">
            <table cellspacing="0" class="tableau-donnees">


            </table>
        </div>
    </section>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/Chart.js/2.9.3/Chart.min.js" integrity="sha256-R4pqcOYV8lt7snxMQO/HSbVCFRPMdrhAFMH+vr9giYI=" crossorigin="anonymous"></script>
    <script src="js/mygraph.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/jquery/3.4.1/jquery.min.js" integrity="sha256-CSXorXvZcTkaix6Yvo6HppcZGetbYMGWSFlBw8HfCJo=" crossorigin="anonymous"></script>
</body>

</html>
