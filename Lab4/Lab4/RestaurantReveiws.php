

<?php
include("./Lab4Common/Common/Header.php");
session_start();
define("REVIEW_PATH",     "restaurant_review.xml");
$saveSuccess = false;
extract($_POST);
$xml = simplexml_load_file(REVIEW_PATH);
if (isset($drpRestaurants) ) {
    $selectedRestaurant = $xml->xpath('./restaurant[@name="' . $drpRestaurants . '"]');
    $address = $selectedRestaurant[0]->address->street_address;
    $city=$selectedRestaurant[0]->address->city;
    $province=$selectedRestaurant[0]->address->province;
    $postal_code=$selectedRestaurant[0]->address->postal_code;
    $summary = $selectedRestaurant[0]->reviews->review->summary;
}
if (isset($_POST['submitSave'])) {
    $xml = simplexml_load_file(REVIEW_PATH);
    $selectedRestaurant = $xml->xpath('./restaurant[@name="' . $drpRestaurants . '"]');
    $selectedRestaurant[0]->address->street_address = $_POST['address'];
    $selectedRestaurant[0]->address->city = $_POST['city'];
    $selectedRestaurant[0]->address->province = $_POST['province'];
    $selectedRestaurant[0]->address->postal_code = $_POST['postal_code'];
    $selectedRestaurant[0]->reviews->review->summary = $_POST['summary'];
    $selectedRestaurant[0]->reviews->review->rating = intval($rating);
    $xml->asXML(REVIEW_PATH);
    $saveSuccess = true;
    $address = $selectedRestaurant[0]->address->street_address;
    $city=$selectedRestaurant[0]->address->city;
    $province=$selectedRestaurant[0]->address->province;
    $postal_code=$selectedRestaurant[0]->address->postal_code;
    $summary = $selectedRestaurant[0]->reviews->review->summary;
}
?>

    <title>Online Restaurant Review</title>
    <script>
        function onRestaurantChanged()
        {
            var reviewForm = document.getElementById('index');
            reviewForm.submit();
        }
    </script>

    
<div class="container">
    <h1>Online Restaurant Reviews</h1><br>
    <form action="RestaurantReveiws.php" method="post" id="index">
    <div class="form-group row">
    
        <label for="drpRestaurants" class="col-sm-2 col-form-label">Restaurant:</label><br>
   
        <select name="drpRestaurants"  class="form-control" onchange="onRestaurantChanged();">
            <option>Select...</option>
        <?php
            foreach($xml->restaurant as $node) {
                foreach ($node->attributes() as $name) {
                    if ($_POST["drpRestaurants"] == $name) {
                        echo('<option value="'. $name . '" SELECTED>' .$name . "</option>");
                    } else {
                        echo('<option value="'. $name . '" >' . $name . "</option>");
                    }
                }
            }
        ?>
        </select>
  </div>

 
       
    <?php
            if(isset($address) && isset($summary)) {
            echo "<div class='form-group row' style='margin-top: 30px;'>";
            echo "<label class='col-sm-2 col-form-label' for='address'>Street Address:</label>";
            echo "<input type='text' class='form-control' style='margin-bottom: 10px;' name='address' value='$address'/> ";
            echo "</div>";
            echo "<div class='form-group row'>";
            echo "<label class='col-sm-2 col-form-label' for='city'>City:</label>";
            echo "<input type='text' class='form-control' style='margin-bottom: 10px;' name='city' value='$city'/>";
            echo "</div>";
            echo "<div class='form-group row' style='margin-top: 30px;'>";
            echo "<label class='col-sm-2 col-form-label' for='province'>Province:</label>";
            echo "<input type='text' class='form-control' style='margin-bottom: 10px;' name='province' value='$province'/> ";
            echo "</div>";
            echo "<div class='form-group row'>";
            echo "<label class='col-sm-2 col-form-label' for='postal_code'>Postal Code:</label>";
            echo "<input type='text' class='form-control' style='margin-bottom: 10px;' name='postal_code' value='$postal_code'/> ";
            echo "</div>";
            echo "<div class='form-group row'>";
            echo "<label class='col-sm-2 col-form-label' style='padding: 5px' for='summary'>Summary:</label><br>";
            echo "<input type='text' class='form-control' style='margin-bottom: 10px; min-height: 250px;' name='summary' value='$summary'/> ";
            echo "</div>";
            echo "<div class='form-group row'>";
            echo "<label class='col-sm-2 col-form-label' for=\'rating\'>Rating:</label>;";
            echo "<select id=\"rating\" name='rating' class='form-control' style='margin-bottom: 10px;'>";
            echo "</div>";
            for ($i = 1; $i < 6; $i++) {
                if ($selectedRestaurant[0]->reviews->review->rating == $i) {
                    echo"<option value='$i' selected>$i</option>";
                } else {
                    echo"<option value='$i'>$i</option>";
                }
            }
            echo '</select>';
        echo '<br><br><br><button name="submitSave" type="submit">Save Changes</button>';
        if($saveSuccess){
            echo "<p>Save successful</p>";
        }
            }
    ?>
   
   
</form>

 </div>
 <?php  include("./Lab4Common/Common/Footer.php");?>

