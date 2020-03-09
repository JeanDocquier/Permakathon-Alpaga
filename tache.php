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
        <a href="#" class="ajouter-une-tache">Ajouter une tâche</a>
        <input type="text" name="Recherche" placeholder="Rechercher une tâche">
        <div class="taches-importantes">
           <h3>Tâches Importantes</h3>
            <table>
                <tr class="une-tache">
                    <!-- INSERTION RÔLE EN FONCTION DE DB -->
                    <td class="date">/** INSERT DATE **/</td>
                    <td class="nom-initateur">/** INSERT NOM **/ <input type="hidden" class="id-initateur"></td> <!-- INSERT ID INITATEUR, VA SERVIR A GRISER LA CASE SUPPRESSION OU NON -->
                    <td class="libelle">/** INSERT LIBELLE-DESCRIPTION **/</td>

                    <form action="" name="check-tache">
                        <input type="text" name="idenntifiant" placeholder="Identifiant">
                        <input type="checkbox">
                        <input type="submit">
                    </form>
                    <td class="suppression"></td>

                </tr>
            </table>
        </div>
        <div class="taches-normales">
           <h3>Tâches </h3>
            <table>
                <tr class="une-tache">
                    <!-- INSERTION RÔLE EN FONCTION DE DB -->
                    <td class="date">/** INSERT DATE **/</td>
                    <td class="nom-initateur">/** INSERT NOM **/ <input type="hidden" class="id-initateur"></td> <!-- INSERT ID INITATEUR, VA SERVIR A GRISER LA CASE SUPPRESSION OU NON -->
                    <td class="libelle">/** INSERT LIBELLE-DESCRIPTION **/</td>

                    <form action="" name="check-tache">
                        <input type="text" name="idenntifiant" placeholder="Identifiant">
                        <input type="checkbox">
                        <input type="submit">
                    </form>
                    <td class="suppression"></td>

                </tr>
            </table>

        </div>
        <div class="taches-faites">
           <h3>Tâches réalisées</h3>
            <table>
                <tr class="une-tache tache-realisee">
                    <!-- INSERTION RÔLE EN FONCTION DE DB -->
                    <td class="date">/** INSERT DATE **/</td>
                    <td class="nom-initateur">/** INSERT NOM **/ <input type="hidden" class="id-initateur"></td> <!-- INSERT ID INITATEUR, VA SERVIR A GRISER LA CASE SUPPRESSION OU NON -->
                    <td class="libelle">/** INSERT LIBELLE-DESCRIPTION **/</td>

                    <td class="check">Fait par /** INSERT IDENTIFIANT **/</td>

                </tr>
            </table>
        </div>
    </section>


    <script src="https://cdnjs.cloudflare.com/ajax/libs/jquery/3.4.1/jquery.min.js" integrity="sha256-CSXorXvZcTkaix6Yvo6HppcZGetbYMGWSFlBw8HfCJo=" crossorigin="anonymous"></script>
    <script src="js/custom.min.js"></script>
</body>

</html>
