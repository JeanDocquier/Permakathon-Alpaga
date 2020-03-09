<!DOCTYPE html>

<html lang="en">

<head>
    <?php include('header.php'); ?>
    <title>PermaFungi - Changer Région</title>

</head>

<body>
    <?php include('menu.php') ?>
    <section id="changer-region">
        <h2>Changer de région</h2>
        <form action="changer-region" name="changer-region">
            <select name="region" id="region">
                <!-- INSERT OPTION EN FONCTION DE DB -->
                <option value="Bruxelles">Bruxelles</option>
                <option value="Charleroi">Charleroi</option>
                <option value="Louvain-La-Neuve">Louvain-La-Neuve</option>
                <option value="Liège">Liège</option>
            </select>
            <input type="submit">
        </form>
    </section>


    <script src="https://cdnjs.cloudflare.com/ajax/libs/jquery/3.4.1/jquery.min.js" integrity="sha256-CSXorXvZcTkaix6Yvo6HppcZGetbYMGWSFlBw8HfCJo=" crossorigin="anonymous"></script>
    <script src="js/custom.min.js"></script>
</body>

</html>
