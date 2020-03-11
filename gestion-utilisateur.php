<!DOCTYPE html>

<html lang="en">

<head>
        <?php include('header.php'); ?>

    <title>PermaFungi - Synérgies</title>

</head>

<body>
   <?php include('menu.php') ?> 
   
   <section id="liste-utilisateur">
   <div class="wrapper-top">
       <h2>Utilisateurs inscrits : </h2>
       <a href="#" class="btn rajouter-employe">
           Ajouter utilisateur
       </a>
       <form action="" method="post" class="ajout-utilisateur">
           <input required type="text" placeholder="Identifiant" class="identifiant-inscription" name="identifiant-inscription">
           <select type="text" placeholder="Fonction" class="fonction-inscription" name="fonction-inscription">
                <option value="Employe">Employe</option>
               <option value="Comptable">Comptable</option>
               <option value="Admin">Admin</option>
           </select>
           <input class="valider-ajout" type="submit" value="Ajouter">
           <span class="fermeture-ajout-utilisateur"><i class="fas fa-window-close"></i></span>
       </form>
   </div>
   <table cellspacing="0" class="liste-utilisateur">
       <tr>
           <th>Identifiant</th>
           <th>Fonction</th>
       </tr>
       <tr>
           <td>Bruce Banner</td>
           <td>Employé</td>
       </tr>
       <tr>
           <td>Carol Danvers</td>
           <td>Comptable</td>
       </tr>
       <tr>
           <td>Steve Rogers</td>
           <td>Employé</td>
       </tr>
       <tr>
           <td>Tony Stark</td>
           <td>Administrateur</td>
       </tr>
   </table> 
      
   </section>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/jquery/3.4.1/jquery.min.js" integrity="sha256-CSXorXvZcTkaix6Yvo6HppcZGetbYMGWSFlBw8HfCJo=" crossorigin="anonymous"></script>
    <script src="js/custom.js"></script>
</body>

</html>
