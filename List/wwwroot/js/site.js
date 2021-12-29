$(document).ready(function () {
    normalizeCardHeight();
    initListItemCheckbox();
});

function normalizeCardHeight()
{
    let maxCardHeight = 0;
    $(".card").each(function (index) {
        if ($(this).height() > maxCardHeight) maxCardHeight = $(this).height();
    });
    $(".card").each(function (index) {
        $(this).height(maxCardHeight);
    });
}

function initListItemCheckbox()
{
    $(".listItemCheckbox").on('change', function () {
        let listItemId = $(this).val();
        let checkedValue = $(this).is(":checked") ? "true" : "false";
        $.ajax({
            url: "https://localhost:44332/ListItems/ListItemCheckedToggle/" + listItemId + "/" + checkedValue,
            success: function (result) {
                console.log(result);

                /*if (result) {
                    console.log("list item updated successfully");
                }
                else
                {
                    console.log("something went wrong");
                }*/
            },
            error: function(error) {
                console.log("something went wrong");
            }
        });
    });
}