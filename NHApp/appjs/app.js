(() => {
    $(".datepicker").inputmask("99/99/9999");
    $(".datepicker").datepicker({
        format: "mm/dd/yyyy",
       minDate: new Date("01/01/1990"),
        yearRange: 40,
        autoClose: true

    });

    //let defaultDateValue = () => {
    //    let today = new Date();
    //    return value
    //}

    $(".ssnmask").inputmask("999-99-9999");
    $('select').formSelect();


    //move next/show next form
    $(".nextForm").click((e) => {
        debugger;

        let form = $(e.target).parents("form");
        //if (form.valid() !== true)
        //    return;
        //let data = $("#formApplicationForm").serialize();
        //console.clear();
        //console.log(data);
        let currentFieldset = $(e.target).parents("fieldset");

        let nextForm = $(currentFieldset).next("fieldset");
        currentFieldset.slideUp("slow");
        nextForm.slideDown("slow");
    });

    //Move previous
    $(".previousForm").click((e) => {
        debugger;
                
        let currentFieldset = $(e.target).parents("fieldset");

        let prev = $(currentFieldset).prev("fieldset");
        currentFieldset.hide("slow");
        prev.show("slow");
    });
})();





