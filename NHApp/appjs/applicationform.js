
$(document).ready(() => {
    $("form").validate();
    $("[name='ArmedForces']").change(() => {
        let selection = $("input[name='ArmedForces']:checked").val();
        alert(selection);
    });

    $("[name = 'HasDrivingLicense']").change(() => {
        let response = $("[name = 'HasDrivingLicense']:checked").val();
        if (response === "No") {
            $("#DLAcknowledgement").slideDown("slow");
        } else {
            $("#DLAcknowledgement").slideUp("slow");
            $("#DriversLicenseModal").modal("show");
        }

    });
});

let loadPreviousEmployer = () => {

    let endpoint = "/PreviousEmployer/AddPreviousEmployer"
    $.ajax({
        url: endpoint,
        type: "GET"
    }).done((response) => {
        $("#PreviousEmployersModalBody").html(response);
        $("#PreviousEmployersModal").modal("show");
    }).fail();
};


