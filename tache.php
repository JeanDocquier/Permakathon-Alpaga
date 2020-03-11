<!DOCTYPE html>

<html lang="en">

<head>
        <?php include('header.php'); ?>

    
    <title>PermaFungi - Tâches</title>

</head>

<body>
    <?php include('menu.php') ?>
    <section id="taches">
        <h2>Liste des tâches</h2>
        <div class="action-taches">
            <a href="#" class="ajouter-une-tache btn">Ajouter une tâche</a>
            <input class="btn-research" type="text" name="Recherche" placeholder="Rechercher une tâche">
        </div>
        <div class="taches-importantes">
           <h3>Tâche(s) Importante(s)</h3>
            <table cellspacing="0" class="liste-taches">
               <tr>
                   <th>Date</th>
                   <th>Initiateur</th>
                   <th>Description</th>
                   <th>Exécuter la tâche</th>
                   <th></th>
               </tr>
                <tr class="une-tache">
                    <!-- INSERTION RÔLE EN FONCTION DE DB -->
                    <td class="date">10 Mars 2020</td>
                    <td class="nom-initateur">Bruce Banner</td> <!-- INSERT ID INITATEUR, VA SERVIR A GRISER LA CASE SUPPRESSION OU NON -->
                    <td class="libelle">Réparer la chambre froide des Pleurottes</td>
                    <td class="execution"><input type="checkbox"></td>

<!--
                    <form action="" name="check-tache">
                        <input type="text" name="idenntifiant" placeholder="Identifiant">
                        <input type="checkbox">
                        <input type="submit">
                    </form>
-->
                    <td class="suppression"><i class="fas fa-trash"></i></td>

                </tr>
            </table>
        </div>
        <div class="taches-normales">
           <h3>Autres Tâches </h3>
            <table cellspacing="0" class="liste-taches">
               <tr>
                   <th>Date</th>
                   <th>Initiateur</th>
                   <th>Description</th>
                   <th>Exécuter la tâche</th>
                   <th></th>
               </tr>
                <tr class="une-tache">
                    <td class="date">7 Mars 2020</td>
                    <td class="nom-initateur">Stever Rogers</td> 
                    <td class="libelle">Contacter Exki pour demander un nouveau contrat</td>
                    <td class="execution"><input type="checkbox"></td>

                    <td class="suppression"><i class="fas fa-trash"></i></td>

                </tr>
                <tr class="une-tache">
                    <td class="date">6 Mars 2020</td>
                    <td class="nom-initateur">Carol Danvers</td> 
                    <td class="libelle">Aller chercher le marc à Louvain-La-neuve</td>
                    <td class="execution"><input type="checkbox"></td>


                    <td class="suppression"><i class="fas fa-trash"></i></td>

                </tr>
                
            </table>

        </div>
        <div class="taches-faites">
           <h3>Tâches réalisées</h3>
            <table cellspacing="0" class="liste-taches">
               <tr>
                   <th>Date</th>
                   <th>Initiateur</th>
                   <th>Description</th>
                   <th>Réalisé par </th>
                   <th>Date de réalisation</th>
               </tr>
                <tr class="une-tache">
                    <td class="date">24 Mars 2020</td>
                    <td class="nom-initateur">Carol Danvers</td> 
                    <td class="libelle">Réparer la chambre froide des Pleurottes</td>
                    <td class="execution">Bruce Banner</td>
                    <td>28 Février 2020</td>

                </tr>
            </table>
        </div>
    </section>


    <script src="https://cdnjs.cloudflare.com/ajax/libs/jquery/3.4.1/jquery.min.js" integrity="sha256-CSXorXvZcTkaix6Yvo6HppcZGetbYMGWSFlBw8HfCJo=" crossorigin="anonymous"></script>
    <script src="js/custom.min.js"></script>
</body>

</html>
