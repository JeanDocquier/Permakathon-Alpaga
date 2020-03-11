<!DOCTYPE html>

<html lang="en">

<head>
    <?php include('header.php'); ?>
    <title>PermaFungi - Utilisateur</title>

</head>

<body>
    <?php include('menu.php') ?>

    <section id="utilisateur">
        <h2>Bienvenu Tony Stark </h2>
        <hr>
        <p>Vous êtes enregistré en tant qu'utilisateur Administrateur</p>
        <p>Vous pouvez sur ce site :</p>
        <ul>
            <!-- INSERTION RÔLE EN FONCTION DE DB -->
            <li>Ajouter des utilisateurs</li>
            <li>Insérer des tâches, les réaliser, les supprimer</li>
            <li>Compléter les informations relatives aux indicateurs</li>
            <li>Changer de région et avoir accès aux contenus des autres immplémentations PermaFungi</li>
        </ul>
    </section>


    <script src="https://cdnjs.cloudflare.com/ajax/libs/jquery/3.4.1/jquery.min.js" integrity="sha256-CSXorXvZcTkaix6Yvo6HppcZGetbYMGWSFlBw8HfCJo=" crossorigin="anonymous"></script>
    <script src="js/custom.min.js"></script>
</body>

</html>
