
function formatWithNull(inptVal) {
    if (!inptVal) {
        return '';
    }

    if (inptVal.includes("\&")) {
        inptVal = inptVal.replaceAll("\&", "%26");
    }

    return inptVal;
}

function tableRowYesOrNo(field) {

    var yesOrNo = 'No';

    if (field) {
        if (field == true || field == '1') {
            yesOrNo = 'Yes';
        }
    }
    return "<td style='text-align:center'>" + yesOrNo + "</td>";
}

function tableRowCenter(field) {
    return "<td style='text-align:center'>" + field + "</td>";
}

function tableRowLeft(field) {
    return "<td style='text-align:left'>" + field + "</td>";
}

function formatBooleanAsYN(field) {

    if (field == false) {
        return "N";
    }

    if (field == "false") {
        return "N";
    }

    if (field == true) {
        return "Y";
    }

    if (field == "true") {
        return "Y";
    }

    return "N";
}

function formatDateTimeAsDate(field) {

    let fieldType = typeof field;

    let dateTime = null;

    if (fieldType == "string") {
        dateTime = new Date(field);
    }

    let rtrnValue = '';

    try {
        rtrnValue = dateTime.toISOString().slice(0, 10);
    }

    catch {
        return "bad date";
    }

    return rtrnValue;
}