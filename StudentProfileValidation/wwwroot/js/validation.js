// Client-side validation for Student Profile Form
document.addEventListener("DOMContentLoaded", function () {
  const form = document.getElementById("studentForm");

  if (form) {
    form.addEventListener("submit", function (event) {
      let isValid = true;

      // Get form fields
      const sName = document.getElementById("sName");
      const fatherName = document.getElementById("fatherName");
      const motherName = document.getElementById("motherName");
      const dob = document.getElementById("dob");
      const sex = document.getElementById("sex");
      const phone = document.getElementById("phone");
      const email = document.getElementById("email");
      const pAddress = document.getElementById("pAddress");
      const permAddress = document.getElementById("permAddress");

      // Validate Student Name
      if (sName && sName.value.trim() === "") {
        alert("Please enter the student's name.");
        sName.focus();
        event.preventDefault();
        return false;
      }

      // Validate Father's Name
      if (fatherName && fatherName.value.trim() === "") {
        alert("Please enter the father's name.");
        fatherName.focus();
        event.preventDefault();
        return false;
      }

      // Validate Mother's Name
      if (motherName && motherName.value.trim() === "") {
        alert("Please enter the mother's name.");
        motherName.focus();
        event.preventDefault();
        return false;
      }

      // Validate Date of Birth
      if (dob && dob.value === "") {
        alert("Please enter a valid date of birth.");
        dob.focus();
        event.preventDefault();
        return false;
      }

      // Validate Age (minimum 3 years)
      if (dob && dob.value) {
        const dobDate = new Date(dob.value);
        const today = new Date();
        const minDate = new Date();
        minDate.setFullYear(today.getFullYear() - 3);

        if (dobDate > minDate) {
          alert("You must be at least 3 years old.");
          dob.focus();
          event.preventDefault();
          return false;
        }
      }

      // Validate Sex
      if (sex && sex.value === "") {
        alert("Please select a gender.");
        sex.focus();
        event.preventDefault();
        return false;
      }

      // Validate Phone Number
      const phonePattern = /^01[3-9][0-9]{8}$/;
      if (phone && !phonePattern.test(phone.value)) {
        alert("Please enter a valid 11-digit phone number starting with 01.");
        phone.focus();
        event.preventDefault();
        return false;
      }

      // Validate Email
      const emailPattern = /^[^\s@]+@[^\s@]+\.[^\s@]+$/;
      if (email && !emailPattern.test(email.value)) {
        alert("Please enter a valid email address.");
        email.focus();
        event.preventDefault();
        return false;
      }

      // Validate Present Address
      if (pAddress && pAddress.value.trim() === "") {
        alert("Please enter your present address.");
        pAddress.focus();
        event.preventDefault();
        return false;
      }

      // Validate Permanent Address
      if (permAddress && permAddress.value.trim() === "") {
        alert("Please enter your permanent address.");
        permAddress.focus();
        event.preventDefault();
        return false;
      }

      return true;
    });
  }
});
